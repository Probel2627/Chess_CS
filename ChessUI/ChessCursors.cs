using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ChessUI
{
    public static class ChessCursors
    {

        public static readonly Cursor WhiteCursor = LoadCursor("Assets/CursorW.cur"); //simple link to our assets with models
        public static readonly Cursor BlackCursor = LoadCursor("Assets/CursorB.cur");

        private static Cursor LoadCursor(string filePath) //method each loading cursor model, we need to use stream for this cause it is not so easy like with images of pieces
        {
            Stream stream = Application.GetResourceStream(new Uri(filePath, UriKind.Relative)).Stream;
            return new Cursor(stream, true); //scale for dpi parameter we r using true in code
        }
    }
}
