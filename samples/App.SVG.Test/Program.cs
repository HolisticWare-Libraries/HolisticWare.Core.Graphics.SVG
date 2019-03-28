using System;

namespace App.SVG.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SVG test!");

            Core.Graphics.SVG.SVG demo = new Core.Graphics.SVG.SVG();
            demo.Types = new Type[]
                                {
                                    //typeof(g),
                                };

            demo.Content =
                            new Core.Graphics.SVG.svgType()
                            {
                                id = "barChart",
                                @class = new string[] { "chart" },
                                width = "420",
                                height = "150",
                                Items = new object[]
                                {
                                    new Core.Graphics.SVG.gType
                                    {
                                        Items = new object[]
                                        {
                                            new Core.Graphics.SVG.rectType
                                            {
                                                width="40", height ="19"
                                            },
                                            new Core.Graphics.SVG.textType
                                            {
                                                x = "45",
                                                y = "9.5",
                                                //dy =".35em",
                                                Text = new string[] {"4 apples" }
                                            },
                                        }
                                    },
                                    new Core.Graphics.SVG.gType
                                    {
                                        Items = new object[]
                                        {
                                            new Core.Graphics.SVG.rectType
                                            {
                                                width="80", height="19", y="20"
                                            },
                                            new Core.Graphics.SVG.textType
                                            {
                                                x="85", y="28", /*dy=".35em"*/
                                                Text = new string[] {"8 bananas" }
                                            },
                                        }
                                    },
                                    new Core.Graphics.SVG.gType
                                    {
                                        Items = new object[]
                                        {
                                            new Core.Graphics.SVG.rectType
                                            {
                                                width="150", height="19", y="40"
                                            },
                                            new Core.Graphics.SVG.textType
                                            {
                                                x="150", y="48", /*dy=".35em"*/
                                                Text = new string[] {"15 kiwis" }
                                            },
                                        }
                                    },
                                    new Core.Graphics.SVG.gType
                                    {
                                        Items = new object[]
                                        {
                                            new Core.Graphics.SVG.rectType
                                            {
                                                width="160", height="19", y="60"
                                            },
                                            new Core.Graphics.SVG.textType
                                            {
                                                x="161", y="68", /*dy=".35em"*/
                                                Text = new string[] {"16 oranges" }
                                            },
                                        }
                                    },
                                    new Core.Graphics.SVG.gType
                                    {
                                        Items = new object[]
                                        {
                                            new Core.Graphics.SVG.rectType
                                            {
                                                width="230", height="19", y="80"
                                            },
                                            new Core.Graphics.SVG.textType
                                            {
                                                x="235", y="88", /*dy=".35em"*/
                                                Text = new string[] {"23 lemons" }
                                            },
                                        }
                                    },
                                }
                            };

            string svg_xml = demo.ToXml();

            Console.WriteLine(svg_xml);

            return;
        }
    }
}

/*
<svg class="chart" width="420" height="150" aria-labelledby="title desc" role="img">
  <title id="title">A bar chart showing information</title>
  <desc id="desc">4 apples; 8 bananas; 15 kiwis; 16 oranges; 23 lemons</desc>
  <g class="bar">
    <rect width="40" height="19"></rect>
    <text x="45" y="9.5" dy=".35em">4 apples</text>
  </g>
  <g class="bar">
    <rect width="80" height="19" y="20"></rect>
    <text x="85" y="28" dy=".35em">8 bananas</text>
  </g>
  <g class="bar">
    <rect width="150" height="19" y="40"></rect>
    <text x="150" y="48" dy=".35em">15 kiwis</text>
  </g>
  <g class="bar">
    <rect width="160" height="19" y="60"></rect>
    <text x="161" y="68" dy=".35em">16 oranges</text>
  </g>
  <g class="bar">
    <rect width="230" height="19" y="80"></rect>
    <text x="235" y="88" dy=".35em">23 lemons</text>
  </g>
</svg>
*/
