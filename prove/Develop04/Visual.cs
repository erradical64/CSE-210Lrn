using System;

class Visual: Activity
{
    private List<string> _image;
    private List<string> _imgName;
    private int _randomNumber;
    private int _guesses;

    private string _chosenImage;
    private string _answer;
    
    
    public Visual()
    {
        _chosenImage = "";
        _randomNumber = 0;
        _answer = "";
        _guesses = 0;
    }
    
    public Visual(int duration, string name, string description, List<string> image, List<string> imgName):base(duration, name, description)
    {
        _image = image;
        _imgName = imgName;
    }
    public void VisualizeThisPls()
    {
        Random random = new Random();
        BeginningTheActivity();
        NamesOfTheImages();
        LoadingAnim(5);
        _randomNumber = random.Next(_imgName.Count);
        _chosenImage = _imgName[_randomNumber];
        if (_chosenImage == "apple")
        {
            //Console.WriteLine("公園でリンゴを食べましょう");
            KudamonoRingo();
            
        }
        else if (_chosenImage == "sock")
        {
            //Console.WriteLine("彼は靴下を着ません");
            Kutsushita();
        }
        else if (_chosenImage == "computer")
        {
            //Console.WriteLine("彼女はパソコンでビデオを見ました");
            PasoCon();
        }
        PrintImage();
        SetTimer();
        Console.WriteLine("What is this object?");
        while (_currentTime < _endingTime)
        {
            _currentTime = DateTime.Now;
            Console.Write(">> ");
            _answer = Console.ReadLine();
            
            _guesses += 1;
            if (_answer.ToLower() == _chosenImage)
            {
                Console.WriteLine($"You guessed it, a {_chosenImage}!");
                _currentTime = _endingTime;
            }
        }
        if (_guesses > 1)
        {
            Console.WriteLine($"You have guessed {_guesses} times!");
        }
        else
        {
            Console.WriteLine($"You have guessed {_guesses} time!");
        }
        
        LoadingAnim(5);
        YouHaveCompleted();

        
    }
    public void PrintImage()
    {
        foreach (string textLine in _image)
        {
            foreach(char l in textLine) 
            {
                Console.Write(l);
                Thread.Sleep(25);
            }
            Console.Write("\n");
        }
        LoadingAnim(5);
    }
    public void KudamonoRingo()
    {
        _image.Add("      | /=>");
        _image.Add("  ___ |/___");
        _image.Add(" /   \\|/ o \\");
        _image.Add("(           )");
        _image.Add(" \\         /");
        _image.Add("  \\       /");
        _image.Add("   \\_/\\__/");
    }
    public void PasoCon()
    {
        _image.Add(" _________________");
        _image.Add("[ ________________] ");
        _image.Add("[[ x = 2 y = 3   ]]");
        _image.Add("[[  z = x * y    ]]");
        _image.Add("[[   print(z)    ]]");
        _image.Add("[[_______________]]");
        _image.Add("[________o________]");
        _image.Add("         |");
        _image.Add("      __/|\\__");

    }
    public void Kutsushita()
    {
        _image.Add("   ________");
        _image.Add("  [        ]");
        _image.Add("  [________]");
        _image.Add("  [/\\/\\/\\/\\]");
        _image.Add("  [________]");
        _image.Add("  [        ]");
        _image.Add(" /        /");
        _image.Add("(________/");
    }
    public void NamesOfTheImages()
    {
        _imgName.Add("apple");
        _imgName.Add("computer");
        _imgName.Add("sock");
    }


   
}