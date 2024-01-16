using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChessKing;
using System;

namespace UnitTestChess960{

    [TestClass]
    
    public class UnitTest1{

        [TestMethod]
        public void IsRandomTrue(){

            //Should fail from time to time due to randomness not always being a guarentee

            frmChessKing king = new frmChessKing();

            Common.IsMode = false;

            Common.IsUnitTest = true;

            king.frmChessKing_Load();

            Common.Is960 = true;

            king.Display();

            Assert.AreEqual(Common.Board[0, 0].Chess.IsCastle, false);

        }

        [TestMethod]
        public void IsRunningNormal(){

            frmChessKing king = new frmChessKing();

            Common.IsMode = false;

            Common.IsUnitTest = true;

            king.frmChessKing_Load();

            king.Display();

            Assert.AreEqual(Common.Board[0, 0].Chess.IsCastle, true);

        }

        [TestMethod]
        public void IsCorrectPiece(){

            //checks if the piece was assigned correct team (had issues with this problem early on)

            frmChessKing king = new frmChessKing();

            Common.IsMode = false;

            Common.IsUnitTest = true;

            king.frmChessKing_Load();

            king.Display();

            Assert.AreEqual(Common.Board[0, 0].Chess.Team, (int)ColorTeam.Black);

        }

        [TestMethod]
        public void IsKingBetweenCastles(){

            //checks if the king is in between the castles

            frmChessKing king = new frmChessKing();

            Common.IsMode = false;

            Common.Is960 = true;

            Common.IsUnitTest = true;

            king.frmChessKing_Load();

            king.Display();

            bool inCastles = false;

            for(int i = 0; i <8; i++){

                if (king.Board[0, i].chess.IsCastle == true){ 
               
                    for(int p = i+1; p < 8; p++){

                        if (king.Board[0,p].chess.IsKing == true){ 

                            for(int q = p+1; q < 8; q++){

                                if (king.Board[0,q].chess.IsCastle == true){ 
                                
                                    inCastles = true;

                                    break;

                                }
                            
                            }
                        
                        }

                    }
                
                }

            }

            Assert.AreEqual(inCastles, true);

        }

        [TestMethod]
        public void IsBishopsOnDifferentSquareColors()
        {

            //checks if bishops are on different colored squares at the start

            frmChessKing king = new frmChessKing();

            Common.IsMode = false;

            Common.Is960 = true;

            Common.IsUnitTest = true;

            king.frmChessKing_Load();

            king.Display();

            bool seperated = false; 

            int b1 = 0;

            int b2 = 0;

            for (int i = 0; i < 8; i++){

                if (king.Board[0, i].chess.IsBishop == true){

                    b1 = i;

                    for (int p = i + 1; p < 8; p++){

                        if(king.Board[0, p].chess.IsBishop == true){ 
                        
                            b2 = p;

                            i = 8;

                            break;
                        
                        }

                    }

                }

            }

            if(b2 - b1 == 1 || b2 - b1 == 3 || b2 - b1 == 5 || b2 - b1 == 7){ 
            
                seperated = true;
                        
            }

            Assert.AreEqual(seperated, true);

        }

    }

}
