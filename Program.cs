using System ;
using System.Collections ;

namespace Question3
{
    class Program
    {
        static void Main (string[] args)
        {
            string sentence = Convert.ToString(Console.ReadLine()) ;
            string s = "" ;

            for ( int i = 0 ; i<sentence.Length-1 ; i++)
                {
                    char c = sentence[i] ;

                    if(c == 'a')
                    {
                        s = s + "a" ;
                    }
                    else if(c == 'e')
                    {
                        s = s + "e" ;
                    }
                    else if(c == 'i')
                    {
                        s = s + "i" ;
                    }
                    else if(c == 'o')
                    {
                        s = s + "o" ;
                    }
                    else if(c == 'u')
                    {
                        s = s + "u" ;
                    }
                }
                Console.WriteLine(s);
                Console.WriteLine(sentence);
                char[] charstr = s.ToCharArray() ;
                char temp ;
                for(int i =1 ; i<charstr.Length ; i++)
                   { for(int j = 0 ; j<charstr.Length-1 ; j++ )
                        {if(charstr[j]>charstr[j+1])
                            {
                                temp=charstr[j] ;
                                charstr[j] = charstr[j+1] ;
                                charstr[j+1]=temp ;
                                
                            }
                        }
                   }        
                            Console.WriteLine(charstr) ;

        }
    }
}