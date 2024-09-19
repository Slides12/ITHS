
WaterGlass wg = new WaterGlass();

wg.FillGlass();
wg.FillGlass();

wg.EmptyGlass();
wg.EmptyGlass();

wg.BreakGlass();

wg.FillGlass();
wg.FillGlass();

wg.EmptyGlass();
wg.EmptyGlass();






class WaterGlass
{
    private bool _isFull = false;
    private bool _isBroken = false;



    public void FillGlass()
    {
       

        if( _isBroken )
        {
            Console.WriteLine("Glaset kan inte fyllas, eftersom det är trasigt.");
        }
        else
        {
            if (!_isFull)
            {
                Console.WriteLine($"Fyller upp glaset.");
                _isFull = true;
            }
            else
            {
                Console.WriteLine($"Glaset är redan fullt.");
            }
        }

    }
    public void EmptyGlass()
    {
        if (!_isFull)
        {
            Console.WriteLine($"Glaset är redan tomt.");

        }
        else
        {
            Console.WriteLine($"Tömmer glaset.");
            _isFull = false;

        }
    }


    public void BreakGlass()
    {
        _isBroken = true;
    }
}