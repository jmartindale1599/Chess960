using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessKing
{
	public delegate void FindWayAction();

	public enum ColorTeam
	{
		None,
		White,
		Black,
	};

	public partial class frmChessKing : Form
	{
		public ChessSquare[,] Board = new ChessSquare[8, 8];
	
		public string linkWhiteCastle = "Image\\Chess_rlt60.png";
		public string linkWhiteBishop = "Image\\Chess_blt60.png";
		public string linkWhiteKnight = "Image\\Chess_nlt60.png";
		public string linkWhiteQueen = "Image\\Chess_qlt60.png";
		public string linkWhiteKing = "Image\\Chess_klt60.png";
		public string linkWhitePawn = "Image\\Chess_plt60.png";
		public string linkBlackCastle = "Image\\Chess_rdt60.png";
		public string linkBlackBishop = "Image\\Chess_bdt60.png";
		public string linkBlackKnight = "Image\\Chess_ndt60.png";
		public string linkBlackQueen = "Image\\Chess_qdt60.png";
		public string linkBlackKing = "Image\\Chess_kdt60.png";
        public string linkBlackPawn = "Image\\Chess_pdt60.png";

		public frmChessKing()
		{
			InitializeComponent();
		}

		public void frmChessKing_Load(object sender = null, EventArgs e = null)
		{
			for (int row = 0; row < 8; row++)
			{
				for (int col = 0; col < 8; col++)
				{
					ChessSquare temp = new ChessSquare();
					if (row % 2 == 0)
					{
						if (col % 2 == 0)
						{
							temp.BackColor = Color.LavenderBlush;
						}
						else
						{
							temp.BackColor = Color.DarkSlateGray;
						}
					}
					else
					{
						if (col % 2 == 0)
						{
							temp.BackColor = Color.DarkSlateGray;
						}
						else
						{
							temp.BackColor = Color.LavenderBlush;
						}
					}

					temp.Location = new Point((col + 1) * 60, (row + 1) * 60);
					temp.Row = row;
					temp.Col = col;
					Board[row, col] = temp;

					Board[row, col].findWayAction += new FindWayAction(OnAction);
					this.Controls.Add(Board[row, col]);

					//Display();
				}
			}
		}

		public void OnAction()
		{
			//Refresh board
			Board = Common.Board;
		}

		/*
		Code for making board down here 
					I Notes 4 things down there:
					I * Wrap all of that in a if statement on Common.IS960 bool
					I * If IS960 == true go into part that does 960 rules
					I * Actually code in the 960 rules
					I * This is actually just a todo list :3
					V
		*/


		


		public async void Display()
		{
			Chess tempChess;

			//pawn
			for (int i = 0; i < 16; i++)
			{
				tempChess = new Pawn();
				if (i < 8)
				{
					tempChess.Team = (int)ColorTeam.Black;
					Board[1, i].Chess = tempChess;
                    Board[1, i].Image = tryGetImage(linkBlackPawn);
					Board[1, i].Chess.Evaluation = -10;

				}
				else
				{
					tempChess.Team = (int)ColorTeam.White;
					Board[6, i - 8].Chess = tempChess;
					Board[6, i - 8].Image = tryGetImage(linkWhitePawn);
					Board[6, i - 8].Chess.Evaluation = 10;
				}
			}

			if(Common.Is960 == false) { 

			//Castle
			for (int i = 0; i < 4; i++)
			{
				tempChess = new Castle();
				if (i < 2)
				{
					tempChess.Team = (int)ColorTeam.Black;
					Board[0, 0].Chess = tempChess;
					Board[0, 7].Chess = tempChess;
					Board[0, 0].Image = tryGetImage(linkBlackCastle);
					Board[0, 7].Image = tryGetImage(linkBlackCastle);
					Board[0, 0].Chess.Evaluation = -50;
					Board[0, 7].Chess.Evaluation = -50;
				}
				else
				{
					tempChess.Team = (int)ColorTeam.White;
					Board[7, 0].Chess = tempChess;
					Board[7, 7].Chess = tempChess;
					Board[7, 0].Image = tryGetImage(linkWhiteCastle);
					Board[7, 7].Image = tryGetImage(linkWhiteCastle);
					Board[7, 0].Chess.Evaluation = 50;
					Board[7, 7].Chess.Evaluation = 50;

				}
			}

			//Knight
			for (int i = 0; i < 4; i++)
			{
				tempChess = new Knight();
				if (i < 2)
				{
					tempChess.Team = (int)ColorTeam.Black;
					Board[0, 1].Chess = tempChess;
					Board[0, 6].Chess = tempChess;
					Board[0, 1].Image = tryGetImage(linkBlackKnight);
					Board[0, 6].Image = tryGetImage(linkBlackKnight);
					Board[0, 1].Chess.Evaluation = -30;
					Board[0, 6].Chess.Evaluation = -30;

				}
				else
				{
					tempChess.Team = (int)ColorTeam.White;
					Board[7, 1].Chess = tempChess;
					Board[7, 6].Chess = tempChess;
					Board[7, 1].Image = tryGetImage(linkWhiteKnight);
					Board[7, 6].Image = tryGetImage(linkWhiteKnight);
					Board[7, 1].Chess.Evaluation = 30;
					Board[7, 6].Chess.Evaluation = 30;
				}
			}

			//Bishop
			for (int i = 0; i < 4; i++)
			{
				tempChess = new Bishop();
				if (i < 2)
				{
					tempChess.Team = (int)ColorTeam.Black;
					Board[0, 2].Chess = tempChess;
					Board[0, 5].Chess = tempChess;
					Board[0, 2].Image = tryGetImage(linkBlackBishop);
					Board[0, 5].Image = tryGetImage(linkBlackBishop);
					Board[0, 2].Chess.Evaluation = -30;
					Board[0, 5].Chess.Evaluation = -30;
				}
				else
				{
					tempChess.Team = (int)ColorTeam.White;
					Board[7, 2].Chess = tempChess;
					Board[7, 5].Chess = tempChess;
					Board[7, 2].Image = tryGetImage(linkWhiteBishop);
					Board[7, 5].Image = tryGetImage(linkWhiteBishop);
					Board[7, 2].Chess.Evaluation = 30;
					Board[7, 5].Chess.Evaluation = 30;

				}
			}

				//Queen
				tempChess = new Queen();
				tempChess.Team = (int)ColorTeam.Black;
				Board[0, 3].Chess = tempChess;
				Board[0, 3].Image = tryGetImage(linkBlackQueen);
				Board[0, 3].Chess.Evaluation = -90;

				tempChess = new Queen();
				tempChess.Team = (int)ColorTeam.White;
				Board[7, 3].Chess = tempChess;
				Board[7, 3].Image = tryGetImage(linkWhiteQueen);
				Board[7, 3].Chess.Evaluation = 90;

				//King
				tempChess = new King();
				tempChess.Team = (int)ColorTeam.Black;
				Board[0, 4].Chess = tempChess;
				Board[0, 4].Image = tryGetImage(linkBlackKing);
				Board[0, 4].Chess.Evaluation = -900;

				tempChess = new King();
				tempChess.Team = (int)ColorTeam.White;
				Board[7, 4].Chess = tempChess;
				Board[7, 4].Image = tryGetImage(linkWhiteKing);
				Board[7, 4].Chess.Evaluation = 900;


            }else{

                //960 RULES:

                Board[0, 0].Chess = null;
                Board[0, 1].Chess = null;
                Board[0, 2].Chess = null;
                Board[0, 3].Chess = null;
                Board[0, 4].Chess = null;
                Board[0, 5].Chess = null;
                Board[0, 6].Chess = null;
                Board[0, 7].Chess = null;
                Board[7, 0].Chess = null;
				Board[7, 1].Chess = null;
				Board[7, 2].Chess = null;
				Board[7, 3].Chess = null;
				Board[7, 4].Chess = null;
				Board[7, 5].Chess = null;
				Board[7, 6].Chess = null;
				Board[7, 7].Chess = null;

                make960Castle();//includes King
				make960Bishop(true);
				make960Bishop(false, Common.temp);
				make960Knight();
				make960Knight();
				make960Queen();

            }

				Common.Board = Board;

        }

		private Image tryGetImage(string link){ 
		
			Image temp = null;

			if(Common.IsUnitTest == true){

				temp = Image.FromFile("C:\\Users\\jmartindale\\Desktop\\Chess960\\Chess960\\Image\\Chess_kdt60.png");
			
			}else temp = Image.FromFile(link);

			return temp;

        }

		private void make960Bishop(bool first, int prior = 0){

            Chess tempChess = new Chess();

			//Bishop

			int p1 = 0;

			if(first == true){

				p1 = doWhilePiece(0,8);

				Common.temp = p1;

			}else{

				p1 = doOddvsEven(prior);

			}


			tempChess = new Bishop();

            tempChess.Team = (int)ColorTeam.Black;
            Board[0, p1].Chess = tempChess;
            Board[0, p1].Image = tryGetImage(linkBlackBishop);
            Board[0, p1].Chess.Evaluation = -30;

			tempChess = new Bishop();

            tempChess.Team = (int)ColorTeam.White;
            Board[7, p1].Chess = tempChess;
            Board[7, p1].Image = tryGetImage(linkWhiteBishop);
            Board[7, p1].Chess.Evaluation = 30;

            Common.Board = Board;

        }

        private void make960Castle(){
            
			int fCastle; //first
			int sCastle; //second
			int king;

			fCastle = makeRandSpot(0, 8);
			
			if(fCastle > 4){ 
			
				sCastle = doWhilePiece(0, fCastle -2);
			
			}else{ 
			
				sCastle = doWhilePiece(fCastle + 2, 8);
			
			}

			//sCastle = doWhileCritInt(fCastle, 0, 7);

            Chess tempChess = new Castle();


            tempChess.Team = (int)ColorTeam.Black;
            Board[0, fCastle].Chess = tempChess;
            Board[0, sCastle].Chess = tempChess;
            Board[0, fCastle].Image = tryGetImage(linkBlackCastle);
            Board[0, sCastle].Image = tryGetImage(linkBlackCastle);
            Board[0, fCastle].Chess.Evaluation = -50;
            Board[0, sCastle].Chess.Evaluation = -50;

            tempChess = new Castle();

            tempChess.Team = (int)ColorTeam.White;
            Board[7, fCastle].Chess = tempChess;
            Board[7, sCastle].Chess = tempChess;
            Board[7, fCastle].Image = tryGetImage(linkWhiteCastle);
            Board[7, sCastle].Image = tryGetImage(linkWhiteCastle);
            Board[7, fCastle].Chess.Evaluation = 50;
            Board[7, sCastle].Chess.Evaluation = 50;

			if(fCastle > sCastle){
	
				king = doWhilePiece(sCastle, fCastle);

			}else{
				
				king = doWhilePiece(fCastle, sCastle);

			}

            //King
            tempChess = new King();

            tempChess.Team = (int)ColorTeam.Black;
            Board[0, king].Chess = tempChess;
            Board[0, king].Image = tryGetImage(linkBlackKing);
            Board[0, king].Chess.Evaluation = -900;

            tempChess = new King();

            tempChess.Team = (int)ColorTeam.White;
            Board[7, king].Chess = tempChess;
            Board[7, king].Image = tryGetImage(linkWhiteKing);
            Board[7, king].Chess.Evaluation = 900;

            Common.Board = Board;

        }

		private void make960Queen(){

            Chess tempChess = new Queen();

            int p1;
            
            p1 = doWhilePiece(0, 8);

            //Queen
            tempChess = new Queen();
            tempChess.Team = (int)ColorTeam.Black;
            Board[0, p1].Chess = tempChess;
            Board[0, p1].Image = tryGetImage(linkBlackQueen);
            Board[0, p1].Chess.Evaluation = -90;

            tempChess = new Queen();
            tempChess.Team = (int)ColorTeam.White;
            Board[7, p1].Chess = tempChess;
            Board[7, p1].Image = tryGetImage(linkWhiteQueen);
            Board[7, p1].Chess.Evaluation = 90;

            Common.Board = Board;

        }

        private void make960Knight(){

            Chess tempChess = new Chess();

            //Knight

            int p1 = 0;

            p1 = doWhilePiece(0, 8);

            tempChess = new Knight();
            
                tempChess.Team = (int)ColorTeam.Black;
                Board[0, p1].Chess = tempChess;
                Board[0, p1].Image = tryGetImage(linkBlackKnight);
                Board[0, p1].Chess.Evaluation = -30;

            tempChess = new Knight();

                tempChess.Team = (int)ColorTeam.White;
                Board[7, p1].Chess = tempChess;
                Board[7, p1].Image = tryGetImage(linkWhiteKnight);
                Board[7, p1].Chess.Evaluation = 30;

            Common.Board = Board;

        }

        private int makeRandSpot(int min, int max){

			Random random = new Random();

			int newI = random.Next(min, max);

			return newI;

		}

        private int doWhilePiece(int min, int max, int prior = 9){ //0, 7

			int spot = 0;

			do{

				spot = 0;

				spot = makeRandSpot(min,max);

			}while(Board[0, spot].Chess != null && spot != prior);

			return spot;

		}

		private int doOddvsEven(int firstPiece){ //0, 7

			int spot = 0;

			if(firstPiece == 1 || firstPiece == 3 || firstPiece == 5 || firstPiece == 7){

				do {

					spot += 2;

				} while (Board[0,spot].Chess != null);

			}else{

				spot = 1;

				do {

					spot += 2;

				} while (Board[0,spot].Chess != null);
			
			
			}

			return spot;

		}

		private void btn2Player_Click(object sender, EventArgs e)
		{
			Display();
			Common.IsMode = true;
			bnt1Player.Enabled = false;
		}

		private void bnt1Player_Click(object sender, EventArgs e)
		{
			Display();
			Common.IsMode = false;
			btn2Player.Enabled = true;
		}

        public void cheSwitch_Mode(object sender, EventArgs e)
        {
            Common.IsMode = false;
			if (Common.Is960 == true){
				Common.Is960 = false;
			}else{
				Common.Is960 = true;
			}
            switch960.Enabled = true;

        }

		public void resetGame(object sender, EventArgs e){ 
		
			for(int i = 0; i < 8; i++){ 
			
				for(int p = 0; p < 8; p++){

					Board[i, p].Chess = null;
					Board[i, p].Image = null;
				
				}
			
			}
		
		}

        private void bntQuit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form2 frmAbout = new Form2();
			frmAbout.ShowDialog();
		}
		/// <summary>
		/// lua chon do sau cho minimax
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			Common.Depth = 1;
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			Common.Depth = 2;
		}

		private void toolStripMenuItem4_Click(object sender, EventArgs e)
		{
			Common.Depth = 3;
		}

		private void toolStripMenuItem5_Click(object sender, EventArgs e)
		{
			Common.Depth = 4;
		}

		private void toolStripMenuItem6_Click(object sender, EventArgs e)
		{
			Common.Depth = 5;
		}

		private void onlineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string url = "http://www.wikihow.com/Play-Chess";

			System.Diagnostics.Process.Start(url);
		}

		private void offlineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form3 frmHelp = new Form3();
			frmHelp.ShowDialog();
		}
	}
}

