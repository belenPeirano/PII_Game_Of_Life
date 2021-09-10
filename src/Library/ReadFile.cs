using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Threading;

namespace PII_Game_Of_Life
{

    public class ReadFile
    {
        
        private string url = @"../../assets/board.txt";
              
        public void ReadFile(string url)
        {
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        }

        for (int  y=0; y<contentLines.Length;y++)
        {
            for (int x=0; x<contentLines[y].Length; x++)
            {
                if(contentLines[y][x]=='1')
                {
                    board[x,y]=true;
                }
            }
        }

    }
}