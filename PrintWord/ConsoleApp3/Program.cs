using System;
using System.Linq;
using System.Collections;

namespace prop
{
    class Btvn
    {
        static int i, j, k,l, count = 6;
        static int c, c1, c2, c3, c4;
        static string input;
        static public void Main(String[] args)
        {

            /* input = Console.ReadLine();*/
            /*line();
            crosstl();*/
            /* gap();
             crosstr();*/
            /*wordMidA();
            wordMidB();
            wordMidC();
            wordMidD();
            wordMidE();
            wordMidF();
            wordMidG();*/
            /*wordMidH();
            wordMidO();*/
            string aa;
            Console.WriteLine("Enter name :");
            aa = Console.ReadLine();

            /*char[] cc = aa.ToCharArray();*/
            char[] cc;
            cc = aa.ToCharArray();
            for (i = 0; i < cc.length; i++ )
            {
                Console.WriteLine(cc);
            }
            
        }


        static void line() // create a line
        {  
            for (k= 0; k <= 2; k++)
            {
                Console.WriteLine("*");
            }
        }

        static void gap() // space
        {
            for (k = 0; k <= 2; k++)
            {
                Console.WriteLine(" ");
            }
        }

        static void crosstr() // triangle top
        {
            for (j= 10; j>= 1; j--)
            {
                Console.WriteLine(" ");
            }
        }

        static void crosstl() // triangle left 
        {
            for (j = 10; j >= 1; j--)
            {
                Console.WriteLine(" ");
            }
        }

        static void crossbr() // bottom right
        {
            for (l = 1; l <= i; l++)
            {
                Console.WriteLine(" ");
            }
        }

        static void crossbl() // bottom left
        {
            for (j = 1; j <= i; j++)
            {
                Console.WriteLine(" ");
            }
        }

        static void wordMidA() 
        {
            for (j = 1; j <= i; j++)
            {
                if (i > 4 && i < 7)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("  ");//add two space  
                }
            }
        }

        static void wordMidB()
        {
            for (l = 1; l <= 5; l++)
            {
                // B
                if (i > 0 && i< 2 || i > 4 && i < 7 || i > 9 && i <= 11)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("  ");//add two space  
                }
            }

            // 
            for (k = 1; k <= 5; k++)
            {
                // B
                if (i > 0 && i < 2 || i > 4 && i < 7 || i > 9 && i <= 11)
                {
                    Console.WriteLine("  ");
                }
                else
                {
                    Console.WriteLine("*");//add two space  
                }
            }
        }

        static void wordMidC()
        {
            for (l = 1; l <= 5; l++)
            {
                // B
                if (i > 0 && i < 2 || i > 9 && i <= 11)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("  ");//add two space  
                }
            }
        }

        static void wordMidH()
        {
            for (j = 1; j <= i; j++)
            {
                if (i > 4 && i < 7)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("  ");//add two space  
                }
            }
        }

        static void wordMidE() // E
        {
            for (l = 1; l <= 5; l++)
            {
                // B
                if (i > 0 && i < 2 || i > 9 && i <= 11)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("  ");//add two space  
                }
            }
        }

        static void wordMidD() //D
        {
            for (l = 1; l <= 5; l++)
            {
                if (i > 0 && i < 2 || i > 9 && i <= 11 ||  l == 5)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("  ");//add two space  
                }
            }

            for (k = 1; k <= 5; k++)
            {
                // B
                if (i > 0 && i < 2 || i > 9 && i <= 11)
                {
                    Console.WriteLine("  ");
                }
                else
                {
                    Console.WriteLine("*");//add two space  
                }
            }
        }
        
        static void wordMidF()
        {
            for (l = 1; l <= 5; l++)
            {
                if (i > 0 && i < 2 || i > 4 && i < 7)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("  ");//add two space  
                }
            }
        }

        static void wordMidG()
        {
            for (l = 1; l <= 5; l++)
            {
                if (i > 0 && i < 2 || (i > 4 && i < 7) && (l >= 3 && l <= 5) || (i >= 6 && i <= 9) && l == 5 || i > 9 && i <= 11)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("  ");//add two space  
                }

                
            }
        }


        static void wordI()
        {
            for (l = 0; l <= 6; l++)
            {
               if (i >= 0 && i <= 2 || (i >= 2 && i<=9) && l == 3 || i> 9 && i<= 11)
               {
                    Console.WriteLine("***");
               } else

               {
                    Console.WriteLine("   ");//add three space  
                
               }
            }
        }

        static void wordJ()
        {
            for (l = 6; l <= 6; l++)
            {
                if (i > 0 && i < 2 || (i > 2 && i < 9) && (l == 3) || (i >= 7 && i <= 9) && l == 0 || (i > 9 && i <= 11) && l <= 3)
                {
                    Console.WriteLine("***");
                }
                else
                {
                    Console.WriteLine("   ");//add three space  
                }
            }
        }

        static void wordK()
        {
            for (l=0; l <= 6; l++)
            {
                if (l == count)
                {
                    Console.WriteLine("***");
                } 
                else
                {
                    Console.WriteLine("   ");//add three space  
                }
            }

            if (i <= 5)
            {
                count--;
            } else if (i <= 11)
            {
                count++;
            }
        }


        static void wordMidL()
        {
            for (l=1; l <= 5; l++)
            {
                if(i>9 && i<=11)
                {
                    Console.WriteLine("**");
                } else
                {
                    Console.WriteLine("  ");
                }
            }
        }

        static void wordMidV()
        {
            for (j = 10; j >= i; j--)
            {
                    Console.WriteLine("  ");
            }
        }

        static void wordMidO()
        {
            for (k = 0; k <= 2; k++)
            {
                if (i == 0 && k <= 2 || i == 1 && k < 1 || i == 11 && k <2 || i == 0 && k < 1)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("*");
                }
            }

            for (l=1; l <= 6; l++)
            {
                if (i >= 0 && i < 2 || i>9 && i <= 11)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("  ");
                }
            }

            for (k = 0; k <= 2; k++)
            {
                if (i == 0 && k > 0 || i == 1 && k > 1 || i == 11 && k > 0 || i == 0 && k > 1)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("*");
                }
            }
        }

        static void wordMidP()
        {
            for (l = 0; l <= 11; k++)
            {
                if ((i > 0 && i<2) && l < 9 || (i >=2 && i < 9) && l == 0 || l==8 && i < 10 || (i >= 9 && i <= 11) && l == i)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("  ");
                }
            }
        }

        
        static void wordMidR()
        {
            for (l = 1; l <= 5; k++)
            {
                if (i >= 0 && i < 2 || i > 4 && i < 7 || (i>= 2 && i <= 4) && l==5 || (i>=7 && i <=11) && l==c4 )
                {
                    Console.WriteLine("**");
                } else
                {
                    Console.WriteLine("  ");
                }
            }


            if (i>6)
            {
                c4++;
            } else if (c4>5)
            {
                c4 = 1;
            }

        }

        static void wordS()
        {
            for (l = 1; l <= 8; k++)
            {
                if (i >= 0 && i < 2 || i > 4 && i < 7 || (i >= 2 && i <= 4) && l == 1 || (i >= 6 && i <= 9) && l == 8  || (i >= 9 && i <= 11))
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("  ");
                }
            }       
        }

        static void wordT()
        {
            for (l=0; l <= 6; l++)
            {
                if (i >= 0 && i <2 || (i >= 2 && i <= 11) && l == 3)
                {
                    Console.WriteLine("**");
                } else
                {
                    Console.WriteLine("  ");
                }
            }
        }

        static void wordU()
        {
            for (l = 0; l <= 6; l++)
            {
                if (i >9 && i <= 11)
                {
                    Console.WriteLine("**");
                }
                else
                {
                    Console.WriteLine("  ");
                }
            }
        }

        static void wordMidW()
        {
            for (l=0; l <= 11; l++)
            {
                Console.WriteLine("  ");
            }
        }

        static void spX()
        {
            for (l = 0; l <= 11; l++)
            {
                if (l == c || l == c1)
                {
                    Console.WriteLine("***");
                } else
                {
                    Console.WriteLine("  ");
                }
            }

            if(i<=4)
            {
                c++;
                c1--;
            } else if (i<= 11)
            {
                c1++;
                c--;
            }
        }

        static void spY()
        {
            for (l = 0; l <= 11; l++)
            {
                if (l == c2 || l == c3 && i < 5)
                {
                    Console.WriteLine("***");
                }
                else
                {
                    Console.WriteLine("  ");
                }
            }
            if (i <= 4)
            {
                c2++;
                c3--;
            }
            else if (i <= 11)
            {
                c3++;
            }

            if (i>= 5)
            {
                Console.WriteLine(" ");
            }

        }












    }

}
