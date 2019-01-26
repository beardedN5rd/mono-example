using System;
using System.Drawing;
using System.Windows.Forms;

public class Program
{
    [STAThread]
    public static void Main()
    {
        var f = new Form();
        f.Text = "Hello World";
        f.Size = new Size(400, 400);

        var b = new Button();
        b.Location = new Point(100, 50);
        b.Size = new Size(200, 50);
        b.Text = "Button";
        f.Controls.Add(b);

        var t = new TextBox();
        t.Location = new Point(100, 120);
        t.Size = new Size(200, 200);
        t.Text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
        t.Multiline = true;
        f.Controls.Add(t);

        Application.Run(f);
    }
}
