namespace Zad10.Properties.Extension;

public static class Exception
{
    public static void ConfigureExceptionHandler(this IApplicationBuilder appBuilder)
    {
        appBuilder.UseExceptionHandler(appError =>
        {
            appError.Run(async context =>
            {
                // Implement exception handling here
            });
        });
    }
}