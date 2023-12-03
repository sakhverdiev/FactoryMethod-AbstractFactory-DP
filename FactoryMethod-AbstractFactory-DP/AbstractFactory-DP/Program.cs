interface IChair
{
    void hasLeg();
    void sitOn();
}

interface ICoffeTable
{
    // ...
}

interface ISofa
{
    // ...
}


class VictorianChair : IChair
{
    public void hasLeg()
    {
        throw new NotImplementedException();
    }

    public void sitOn()
    {
        throw new NotImplementedException();
    }
}


class ModernChair : IChair
{
    public void hasLeg()
    {
        throw new NotImplementedException();
    }

    public void sitOn()
    {
        throw new NotImplementedException();
    }
}





interface IFurnitureFactory
{
    IChair createChair();
    ICoffeTable createCoffeTable();
    ISofa createSofa();
}


class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair createChair()
    {
        throw new NotImplementedException();
    }

    public ICoffeTable createCoffeTable()
    {
        throw new NotImplementedException();
    }

    public ISofa createSofa()
    {
        throw new NotImplementedException();
    }
}


class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair createChair()
    {
        throw new NotImplementedException();
    }

    public ICoffeTable createCoffeTable()
    {
        throw new NotImplementedException();
    }

    public ISofa createSofa()
    {
        throw new NotImplementedException();
    }
}