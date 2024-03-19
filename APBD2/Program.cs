using APBD2;
try
{
    CContainer cContainer = new CContainer(100, 100, 100, 1000, Product.FrozenPizza);

    cContainer.Load(100, -1000);
    cContainer.Load(100, 30);
    cContainer.Load(1001, 30);
    cContainer.EmptyLoading();
    cContainer.Load(1000, 30);

} catch(OverfillException e)
{
    Console.WriteLine(e.Message);
}

try
{

    LContainer lContainer = new LContainer(100, 100, 100, 1000, LoadType.Safe);

    lContainer.Load(900);
    lContainer.EmptyLoading();
    lContainer.Load(901);

}
catch (OverfillException e)
{
    Console.WriteLine(e.Message);
}

try
{

    LContainer lContainer = new LContainer(100, 100, 100, 1000, LoadType.Hazard);
    lContainer.Load(500);
    lContainer.EmptyLoading();
    lContainer.Load(501);
}
catch (OverfillException e)
{
    Console.WriteLine(e.Message);
}



try
{
    GContainer gContainer = new GContainer(100, 100, 100, 1000);
    gContainer.Load(999);
    gContainer.EmptyLoading();
    gContainer.Load(995);
}
catch (OverfillException e)
{
    Console.WriteLine(e.Message);
}