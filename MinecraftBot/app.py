import pyautogui as pt
from time import sleep
import cv2 as cv2

#funkce na startnutí minecraftu z menu
def menu_start():
    resume_button = (900,330)
    pt.moveTo(resume_button)
    pt.click()

#funkce na udělnání screenshotu
def screenshot():
    screenshot = pt.screenshot()
    screenshot.save("screen.png")

#funkce na porovnání obrázků a těžení bloku  
def porovnani():
    img = cv2.imread("screen.png")
    blok = cv2.imread("coble.png")
    result = cv2.matchTemplate(img , blok, cv2.TM_CCOEFF_NORMED)
    min_val, max_val, min_loc, max_loc = cv2.minMaxLoc(result)
    if max_val > 0.8:
        pt.mouseDown()
        sleep(0.6)
        pt.mouseUp()
    else:
        print("Blok tady není")



sleep(3)
menu_start()
x = 1
while x < 10:  
    screenshot()
    porovnani()
    x += 1
    sleep(2)
