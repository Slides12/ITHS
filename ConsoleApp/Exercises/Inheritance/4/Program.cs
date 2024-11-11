using System.ComponentModel.DataAnnotations;

struct Size
{
    public double Length { get; set; }
    public double Height { get; set; }
    public double Width { get; set; }


    public Size(double length, double height, double width)
    {
        this.Length = length;
        this.Height = height;   
        this.Width = width;
    }
}