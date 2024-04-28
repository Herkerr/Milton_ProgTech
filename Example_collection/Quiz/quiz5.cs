// 1, Olvassunk kódot!
// 2, Ismerjük fel milyen tervezési mintát láthatunk a kódban?

using System;

public interface IExistingUIComponent
{
    void Render();
}

public class ExistingButton : IExistingUIComponent
{
    public void Render()
    {
        Console.WriteLine("Rendering button from the existing UI component library...");
    }
}


public interface INewUIComponent
{
    void Draw();
}


public class ExistingButtonCompat : INewUIComponent
{
    private readonly IExistingUIComponent existingButton;

    public ExistingButtonCompat(IExistingUIComponent existingButton)
    {
        this.existingButton = existingButton;
    }

    public void Draw()
    {
        existingButton.Render();
    }
}

public class NewButton : INewUIComponent
{
    public void Draw()
    {
        Console.WriteLine("Drawing button from the new UI framework...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IExistingUIComponent existingButton = new ExistingButton();
        UseNewUIComponent(existingButton);

        INewUIComponent newButton = new NewButton();
        UseNewUIComponent(newButton);
    }

    static void UseNewUIComponent(INewUIComponent component)
    {
        component.Draw();
    }
}
