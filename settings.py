# SayoDevice 03C

# Rapid trigger settings (sayo_backup_ikuyo_kita)

# Analog key
Stroke = "4.000mm"
Release = "0.130mm"
Triggle = "0.260mm"

# RT MODE = ON
rt_release = "0.300"
rt_triggle = "0.300"

# Full stroke
rt_match = "speed = 2"

# Fn0 (Color Mode)
Fn0 = "Fn0"

# color
light_mode = "Static"
color_mode = "Static color"
color = "FF3232"
Triggle_event = "Press fade in, release fade out"

# Fn1 (Color Mode)
Fn1 = "Fn1"

# color
light_mode_fn1 = "Static"
color_mode_fn1 = "Static color"
color_fn1 = "0078D7"
Triggle_event_fn1 = "Press fade in, release fade out"

# Fn2 (Color Mode)
Fn2 = "Fn2"

# color 
light_mode_fn2 = "Static"
color_mode_fn2 = "Static color"
color_fn2 = "D59FF"
Triggle_event_fn2 = "Press fade in, release fade out"


print("Rapid Trigger Settings")
print(f"Stroke = {Stroke}, Release = {Release}, Triggle = {Triggle}")
print("RT MODE ON")
print(f"rt_release = {rt_release}, rt_triggle = {rt_triggle}")
print("Full stroke")
print(f"rt_match = {rt_match}")

# Fn0 Color mode
print("Fn0 (Color Mode)")
print(f"light_mode {light_mode}, color_mode = {color_mode}, color = {color}, triggle_event = {Triggle_event}")

# Fn1 Color mode
print("Fn1 (Color Mode)")
print(f"light_mode_fn1 = {light_mode_fn1}, color_mode_fn1 = {color_mode_fn1}, color_fn1 = {color_fn1}, triggle_event_fn1 = {Triggle_event_fn1}")

# Fn2 Color mode
print("Fn2 (Color Mode)")
print(f"light_mode_fn2 = {light_mode_fn2}, color_mode_fn2 = {color_mode_fn2}, color_fn2 = {color_fn2}, triggle_event_fn2 = {Triggle_event_fn2}")


