using System;


/*
 * This class will store the data when read and written to the JSON file for simplicity
 */
namespace MegaDesk4
{
    public class QuoteData
    {
        string name;
        int width;
        int depth;
        int drawers;
        string material;
        int order;
        DateTime date;
        int total;
        public QuoteData() { }

        public string Name { get => name; set => name = value; }
        public int Width { get => width; set => width = value; }
        public int Depth { get => depth; set => depth = value; }
        public int Drawers { get => drawers; set => drawers = value; }
        public string Material { get => material; set => material = value; }
        public int Order { get { return order; } set { order = value; } }
        public DateTime Date { get => date; set => date = value; }
        public int Total { get => total; set => total = value; }
    }
}