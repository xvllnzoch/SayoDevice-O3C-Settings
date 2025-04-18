#include <iostream>
#include <string>

using namespace std;

// Rapid trigger settings (sayo_backup_ikuyo_kita)

// Analog key
string Stroke = "4.000mm";
string Release = "0.130mm";
string Triggle = "0.260mm";

// RT MODE = ON
string rt_release = "0.300";
string rt_triggle = "0.300";

// Full stroke
string rt_match = "speed = 2";

// Fn0 (Color Mode)
string Fn0 = "Fn0";

// color
string light_mode = "Static";
string color_mode = "Static color";
string color = "FF3232";
string Triggle_event = "Press fade in, release fade out";

// Fn1 (Color Mode)
string Fn1 = "Fn1";

// color
string light_mode_fn1 = "Static";
string color_mode_fn1 = "Static color";
string color_fn1 = "0078D7";
string Triggle_event_fn1 = "Press fade in, release fade out";

// Fn2 (Color Mode)
string Fn2 = "Fn2";

// color 
string light_mode_fn2 = "Static";
string color_mode_fn2 = "Static color";
string color_fn2 = "D59FF";
string Triggle_event_fn2 = "Press fade in, release fade out";

int main() {
    cout << "Rapid Trigger Settings" << endl;
    cout << "Stroke = " << Stroke << ", Release = " << Release << ", Triggle = " << Triggle << endl;
    cout << "RT MODE ON" << endl;
    cout << "rt_release = " << rt_release << ", rt_triggle = " << rt_triggle << endl;
    cout << "Full stroke" << endl;
    cout << "rt_match = " << rt_match << endl;
    
    // Fn0 Color mode
    cout << "Fn0 (Color Mode)" << endl;
    cout << "light_mode " << light_mode << ", color_mode = " << color_mode << ", color = " << color << ", triggle_event = " << Triggle_event << endl;
    
    // Fn1 Color mode
    cout << "Fn1 (Color Mode)" << endl;
    cout << "light_mode_fn1 = " << light_mode_fn1 << ", color_mode_fn1 = " << color_mode_fn1 << ", color_fn1 = " << color_fn1 << ", triggle_event_fn1 = " << Triggle_event_fn1 << endl;
    
    // Fn2 Color mode
    cout << "Fn2 (Color Mode)" << endl;
    cout << "light_mode_fn2 = " << light_mode_fn2 << ", color_mode_fn2 = " << color_mode_fn2 << ", color_fn2 = " << color_fn2 << ", triggle_event_fn2 = " << Triggle_event_fn2 << endl;
    
    return 0;
}