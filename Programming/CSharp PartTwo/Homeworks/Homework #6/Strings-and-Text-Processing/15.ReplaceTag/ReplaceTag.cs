/*Write a program that replaces in a HTML
 *document given as string all the tags <a 
 *href="…">…</a> with corresponding tags 
 *[URL=…]…/URL].
 */
using System;

class ReplaceTag
{
    static void Main()
    {
        string str = @"<p>Please visit <a href=""http://academy.telerik.com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        string anchorTag = @"<a href=""";
        string tagClose = @""">";
        string closingAnchorTag = "</a>";

        str = str.Replace(anchorTag, "[URL=");
        str = str.Replace(tagClose, "]");
        str = str.Replace(closingAnchorTag, "[/URL]");
        Console.WriteLine(str);
    }
}
