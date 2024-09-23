using System.ComponentModel.DataAnnotations;

struct Size
{
    public int Length { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }


    public Size(int length, int height, int width)
    {
        this.Length = length;
        this.Height = height;   
        this.Width = width;
    }
}