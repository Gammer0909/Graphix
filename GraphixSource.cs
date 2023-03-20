using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using Graphix;

namespace Graphix
{
    public class Draw
    {
    
        public static void Pixel(ConsoleColor color)
        {
        
            Console.BackgroundColor = color;
            Console.Write(" ");
            Console.ResetColor();
        
        }
    
        public static void PixelChar(ConsoleColor color, ConsoleColor textColor, char pixelChar)
        {
        
            Console.BackgroundColor = color;
            Console.ForegroundColor = textColor;
            Console.Write(pixelChar);
            Console.ResetColor();
        
        }
    
        public static void PixelString(ConsoleColor color, ConsoleColor textColor, string pixelString)
        {
        
            Console.BackgroundColor = color;
            Console.ForegroundColor = textColor;
            Console.Write(pixelString);
            Console.ResetColor();
        
        }
    
        public static void PixelStringDelay(ConsoleColor color, ConsoleColor textColor, string pixelString, int delay)
        {
        
            for (int i = 0; i < pixelString.Length; i++)
            {
                
                Console.BackgroundColor = color;
                Console.ForegroundColor = textColor;
                Console.Write(pixelString[i].ToString());
                Thread.Sleep(delay);
            
            
            }
        
        }
    
    }
    
    
}
