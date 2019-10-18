﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class WriteBytes
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("D:\\data.txt", FileMode.OpenOrCreate);

            for (int i = 65; i <= 90; i++)
            {
                f.WriteByte((byte)i);
            }

            Console.WriteLine();
            for (int i = 97; i <= 122; i++)
            {
                f.WriteByte((byte)i);

            }

            f.Close();

        }

    }
}
