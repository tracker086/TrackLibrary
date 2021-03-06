﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackLibrary.W8.Services.LiveTile;

namespace TrackLibrary.W8.Services.LiveTile
{
    public class TileWideBlockAndText02 : ITileBase, ITileWide
    {
        public string Text01 { get; set; }
        public string Text02 { get; set; }
        public string Text03 { get; set; }

        public string ToXml()
        {
            string xml = String.Format(@"<tile>
                                          <visual>
                                            <binding template='TileWideBlockAndText02'>
                                              <text id='1'>{0}</text>
                                              <text id='2'>{1}</text>
                                              <text id='3'>{2}</text>
                                            </binding>  
                                          </visual>
                                        </tile>", Text01, Text02, Text03);
            return xml;
        }
    }
}
