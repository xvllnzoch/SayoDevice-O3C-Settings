using System;

class SayoDeviceO3C
{   // in case I lost the Original
    // Rapid trigger settings (sayo_backup_ikuyo_kita)

    // Analog key
    public static string Stroke = "4.000mm";
    public static string Release = "0.130mm";
    public static string Triggle = "0.260mm";

    // RT MODE = ON
    public static string rt_release = "0.300";
    public static string rt_triggle = "0.300";

    // Full stroke
    public static string rt_match = "speed = 2";

    // Fn0 (Color Mode)
    public static string Fn0 = "Fn0";

    // color
    public static string light_mode = "Static";
    public static string color_mode = "Static color";
    public static string color = "FF3232";
    public static string Triggle_event = "Press fade in, release fade out";

    // Fn1 (Color Mode)
    public static string Fn1 = "Fn1";

    // color
    public static string light_mode_fn1 = "Static";
    public static string color_mode_fn1 = "Static color";
    public static string color_fn1 = "0078D7";
    public static string Triggle_event_fn1 = "Press fade in, release fade out";

    // Fn2 (Color Mode)
    public static string Fn2 = "Fn2";

    // color 
    public static string light_mode_fn2 = "Static";
    public static string color_mode_fn2 = "Static color";
    public static string color_fn2 = "D59FF";
    public static string Triggle_event_fn2 = "Press fade in, release fade out";

    public static void Main(string[] args)
    {
        Console.WriteLine("Rapid Trigger Settings");
        Console.WriteLine($"Stroke = {Stroke}, Release = {Release}, Triggle = {Triggle}");
        Console.WriteLine("RT MODE ON");
        Console.WriteLine($"rt_release = {rt_release}, rt_triggle = {rt_triggle}");
        Console.WriteLine("Full stroke");
        Console.WriteLine($"rt_match = {rt_match}");

        // Fn0 Color mode
        Console.WriteLine("Fn0 (Color Mode)");
        Console.WriteLine($"light_mode {light_mode}, color_mode = {color_mode}, color = {color}, triggle_event = {Triggle_event}");

        // Fn1 Color mode
        Console.WriteLine("Fn1 (Color Mode)");
        Console.WriteLine($"light_mode_fn1 = {light_mode_fn1}, color_mode_fn1 = {color_mode_fn1}, color_fn1 = {color_fn1}, triggle_event_fn1 = {Triggle_event_fn1}");

        // Fn2 Color mode
        Console.WriteLine("Fn2 (Color Mode)");
        Console.WriteLine($"light_mode_fn2 = {light_mode_fn2}, color_mode_fn2 = {color_mode_fn2}, color_fn2 = {color_fn2}, triggle_event_fn2 = {Triggle_event_fn2}");
        Console.ReadKey();
    }
}