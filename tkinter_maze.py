from tkinter import *
from tkinter import ttk

x_coords = 0
y_coords = 0
x_goal = 3
y_goal = 3

def movement(direction):
    
    global x_coords
    global y_coords
    
    if direction == "up":
        y_coords += 1
    if direction == "down":
        y_coords -= 1
    if direction == "right":
        x_coords += 1
    if direction == "left":
        x_coords -= 1
        
    current_loc.set(f"Current Location: ({x_coords}, {y_coords})")
    
    if x_coords == x_goal and y_coords == y_goal:
        win.set("Maze has been conquered. You've won the game!")
        
        ttk.Button
        
        
root = Tk()
root.title("Maze of Martorillas")

mainframe = ttk.Frame(root, padding=(50,50,50,50)) 
mainframe.grid(column = 0, row = 0, sticky = (N,W,E,S))

ttk.Label(mainframe, text="Welcome to Martorillas’ Maze").grid(column=2, row=1, sticky=(N,W,E,S))

ttk.Label(mainframe, text="""
You have 4 options of movement:

- [Up] will increase your y-level by 1
- [Down] will decrease your y-level by 1
- [Right] will increase your x-level by 1
- [Left] will decrease your x-level by 1
""").grid(column=2, row=2, sticky=(N,W,E,S))


ttk.Label(mainframe, text=f"""Find the treasure at ({x_goal},{y_goal})!
""").grid(column=2, row=3, sticky=(N,W,E,S))

up_button = ttk.Button(mainframe, text="Up", command = lambda: movement("up"))
up_button.grid(column = 2, row = 5, sticky = (N,S))
ttk.Label(mainframe, text="⇧").grid(column = 2, row = 6, sticky = (N,S))

down_button = ttk.Button(mainframe, text="Down", command = lambda: movement("down"))
down_button.grid(column = 2, row = 9, sticky = (N,S))
ttk.Label(mainframe, text="⇩").grid(column = 2, row = 8, sticky = (N,S))

right_button = ttk.Button(mainframe, text="Right", command = lambda: movement("right"))
right_button.grid(column = 5, row = 7, sticky = (W,E))
ttk.Label(mainframe, text="⇨").grid(column = 4, row = 7, sticky = (W,E))

left_button = ttk.Button(mainframe, text="Left", command = lambda: movement("left"))
left_button.grid(column = 1, row = 7, sticky = (W,E))
ttk.Label(mainframe, text="⇦").grid(column = 2, row = 7, sticky = (W,E))

current_loc = StringVar()
current_loc.set(f"Current Location: (0,0)")
ttk.Label(mainframe, textvariable = current_loc).grid(column=2, row=7, sticky=(N,S))


ttk.Label(mainframe, text="").grid(column = 2, row = 10, sticky = (N,S))

win = StringVar()
win.set("")
ttk.Label(mainframe, textvariable=win).grid(column = 2, row = 11, sticky = (N,S))



root.mainloop()
