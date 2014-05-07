using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Game
    {
        public enum GamePoints
        {
            Fallen,
            Crushed
        }
        public Player player;
        public List<TetrisForm> tetrisForms;
        public TetrisForm activeForm;
        public TetrisForm nextForm;
        public GameState gameState;
        public bool HasNewPoints { get; set; }
        private int MAXX;
        private int MAXY;
        private System.Windows.Forms.Timer timer;
        public int[,] matrix;

        public Game(int maxx, int maxy, System.Windows.Forms.Timer t) {
            gameState = new PreGameState(this);
            resetGame(maxx,maxy);
            timer = t;
        }
        public void newGame()
        {
            resetGame(MAXX,MAXY);
            activeForm = getRandomForm();
            tetrisForms.Add(activeForm);
            nextForm = getRandomForm();
            HasNewPoints = true;
            gameState = new ActiveState(this);
            timer.Start();
        }
        private void resetGame(int maxx, int maxy)
        {
            player = new Player();
            tetrisForms = new List<TetrisForm>();
            MAXX = maxx;
            MAXY = maxy;
            matrix = new int[maxx, maxy];
            for (int i = 0; i < maxx; i++)
            {
                for (int j = 0; j < maxy; j++)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        public void changePoints(GamePoints gp, int count)
        {
            if (gp==GamePoints.Fallen)
            {
                player.Points += (5*player.Level);
                int y = (5 * player.Level);
                HasNewPoints = true;
            }
            else
            {
                player.Points += (50 * player.Level * count);
                HasNewPoints = true;
            }
        }
        public void addNewForm() {
            activeForm = nextForm;
            tetrisForms.Add(activeForm);
            nextForm = getRandomForm();
            if (isGameOver()) {
                gameOver();
            }
            
        }

        private TetrisForm getRandomForm() {
            Random r = new Random();
            int k = r.Next(7);

            if (k == 0) {
                return new RowForm(MAXX, MAXY);
            }
            else if (k == 1) {
                return new SquareForm(MAXX, MAXY);
  
            }
            else if (k == 2)
            {
                return new ZForm(MAXX, MAXY);
            }
            else if (k == 3)
            {
                return new GForm(MAXX, MAXY);
            }
            else if (k == 4) {
                return new CForm(MAXX, MAXY);
            }
            else if (k == 5) {
                return new LForm(MAXX, MAXY);
            }
            else if (k == 6) {
                return new TForm(MAXX, MAXY);
            }
            return null;
        }

        public void moveDown()
        {
            gameState.moveDown();
        }

        public List<Coordinate> returnBackCoordinates(List<Coordinate> list) {
            List<Coordinate> result = new List<Coordinate>();

            for (int i = 0; i < list.Count; i++) {
                result.Add(new Coordinate(list.ElementAt(i).X,list.ElementAt(i).Y-1));   
            }
            return result;
        }

        public void addCoordinateToMatrix(List<Coordinate> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int x = list.ElementAt(i).Y;
                int y = list.ElementAt(i).X;
                matrix[x, y] = 1;
            }
        }

        public void moveLeft()
        {
            gameState.moveLeft();
        }
        

        public void moveRight()
        {
            gameState.moveRight();
        }

        public bool checkMoving(List<Coordinate> coordinateList) {
            int x;
            int y;
            for (int i = 0; i < coordinateList.Count; i++)
            {
                x = coordinateList.ElementAt(i).Y;
                y = coordinateList.ElementAt(i).X;
                int k = matrix[x, y];
                if (k == 1) return false;
            }
            return true;
        }

        public void draw(Graphics g)
        {
            gameState.draw(g);
        }

        public void rotate() {
            gameState.rotate();
        }

        public List<int> checkForRowComplete() {
          
            bool flag = true;
            List<int> RowList = new List<int>();

            for (int i = 0; i < MAXX; i++) {
                flag = true;
                for (int j = 0; j < MAXY; j++) {
                    if (matrix[i, j] != 1) { flag = false; break; }
                }
                if (flag) { RowList.Add(i); }
            }
            return RowList;
        }

        public void RowComplete() {
            List<int> rowList = checkForRowComplete();
            if (rowList.Count > 0)
            {
                int count = rowList.Count;
                int temp = rowList[0];
                foreach (TetrisForm t in tetrisForms)
                    t.deleteSquares(rowList);
                foreach (TetrisForm t in tetrisForms)
                    t.moveDownSquares(rowList[rowList.Count-1], count);
                
                moveDownMatrix(rowList[rowList.Count-1],count);
                changePoints(GamePoints.Crushed, count);
                Sounds.SplashPlay();
                player.Rows += count;
            }
        }

        public void moveDownMatrix(int position, int spaces) {

            for (int i = position; i > spaces; i--)
            {
                for (int j = 0; j < MAXY; j++)
                {
                    int a = matrix[i, j];
                    int b = matrix[i - spaces, j];
                    matrix[i, j] = matrix[i - spaces, j];
                    matrix[i - spaces, j] = 0;
                }
            }
            for (int i = 0; i <= spaces; i++) {
                for (int j = 0; j < MAXY; j++) {
                    matrix[i,j] = 0;
                }
            }
        }

        public void DeleteTetrisForm() {
            List<TetrisForm> temp = new List<TetrisForm>();
            foreach (TetrisForm t in tetrisForms) {
                if (t.SquareListCount == 0) temp.Add(t);
            }
            foreach (TetrisForm t in temp){
                tetrisForms.Remove(t);
            }
        }

        private bool isGameOver() {
            List<Square> squareList = activeForm.SquareList.Where(e => e.Y == activeForm.SouthField).ToList();
            foreach (Square s in squareList) {
                 for(int i=activeForm.WestField;i<activeForm.EastField;i++){
                    if (matrix[s.Y + 1, i] == 1)
                    {
                        return true;
                    }
                }
            }
        return false;
        }
        

        private void gameOver() {
            timer.Stop();
            gameState = new GameOverState(this);
        }

        public void Pause()
        {
            if (gameState as ActiveState != null)
            {
                gameState = new PausedState(this);
                timer.Stop();
            }
            else if (gameState as PausedState!=null)
            {
                timer.Start();
                gameState = new ActiveState(this);
            }
        }
    
    }
}
