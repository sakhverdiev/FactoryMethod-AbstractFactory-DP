abstract class Dialog
{
    public void render()
    {
        Button okButton = createButton();
        okButton.onClick();
        okButton.render();
    }

    public virtual Button createButton()
    {
        return null;
    }

}

interface Button
{
    void render();
    void onClick();

}


class WindowsDialog : Dialog
{
    public override Button createButton()
    {
        return new WindowsButton();
    }
}

class WebDialog : Dialog
{
    public override Button createButton()
    {
        return new WindowsButton();
    }
}

class WindowsButton : Button
{
    public void onClick() { }

    public void render() { }
}

class HTMLButton : Button
{
    public void onClick() {  }

    public void render() { }
}