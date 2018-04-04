﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

// ZAP - Zelda Asset Processor

namespace ZAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Test(ZFileMode.Extract);
            Test(ZFileMode.Build);
        }

        static void Test(ZFileMode fileMode)
        {
            XmlReader reader = XmlReader.Create("textures.xml");

            while (!reader.EOF)
            {
                reader.Read();

                if (reader.Name == "File")
                {
                    ZFile file = new ZFile(fileMode, ref reader);

                    if (fileMode == ZFileMode.Extract)
                        file.ExtractResources();
                    else
                        file.BuildResources();
                }

                //Console.WriteLine(reader.Name);
            }
        }

        static void Extract(string xmlPath)
        {

        }

        static void Build(string xmlPath)
        {

        }
    }
}
