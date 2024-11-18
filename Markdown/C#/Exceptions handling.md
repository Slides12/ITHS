#  Exceptions handling

* try 
    * Testar så att koden fungerar

* catch(Exception e) 
    * Fångar alla typer av error 
    *   kan dirigera 
    * Finns massa varianter på (Exception e), t.ex (IndexOutOFRangeException e) Du kan även lämna denna utan ()
    
    * Man kan ha flera catch för att fånga olika typer av meddelanden.

    ```    
    Console.WriteLine($"Felet är detta: \n{e.Message}");
    ```
    * Om du nestar try catch och den innersta catchar så bryts även de yttre catch. ( De yttersta körs aldrig)
   
   * throw kastar felet till en annan catch ( Kan avändas till att kasta felet till en fil där allt loggas t.ex)

* finally 
    * Körs alltid (T.ex stänga program etc)


