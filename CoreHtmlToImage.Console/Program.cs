﻿using System.IO;

namespace CoreHtmlToImageWArgs.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // From HTML string
            var converter = new HtmlConverter();
            var html = "<div><strong>Hello</strong> World!</div>";
            var htmlBytes = converter.FromHtmlString(html);

            // From URL
            var urlBytes = converter.FromUrl("http://google.com", 800, format: ImageFormat.Png, quality: 90);
            File.WriteAllBytes("D:\\image.png", urlBytes);
        }
    }
}
