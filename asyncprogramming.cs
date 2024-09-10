async Task<int> GetNumberWithErrorAsync()
{
    await Task.Delay(1000); // simulate async work
    throw new Exception("An error ocurred");
}

async void CallAsyncMethod()
{
    try
    {
        int result = await GetNumberWithErrorAsync();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.message); //output An error ocurred
    }
}