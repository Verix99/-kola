karty ="""123456 1234 18900
764538 4321 87900
761538 1235 87900
936472 1010 283800
764539 1234 98600"""

pocet_pokusu = 0
menu_funkce = 0

def vybrat_hotovost():
    vyber_castka = input("Zadejte částku kterou chcete vydat: ")
    if int(vyber_castka) % 200 == 0: 
        pocet_petitisic = 0
        pocet_dvoutisic = 0
        pocet_tisic = 0
        pocet_dveste = 0
        castka = int(vyber_castka)
        pocet_petitisic = castka // 5000
        pocet_dvoutisic = (castka - (5000 * pocet_petitisic)) //2000
        pocet_tisic = (castka - ((5000 * pocet_petitisic) + (2000 * pocet_dvoutisic))) //1000
        pocet_dveste = (castka - ((5000 * pocet_petitisic) + (2000 * pocet_dvoutisic) + (1000 * pocet_tisic))) //200
    
        print(str(castka) + " = ")
        print(str(pocet_petitisic) + "x 5000")
        print(str(pocet_dvoutisic) + "x 2000")
        print(str(pocet_tisic) + "x 1000")
        print(str(pocet_dveste) + "x 200")

        data[2] = int(data[2]) - castka
    else:
        print("Zadanou částku nejde vybrat.")
def zmena_pinu():
    novy_pin = input("zadejte nový pin: ")
    novy_pin_2 = input("Zadejte znovu nový pin: ")
    if novy_pin == novy_pin_2:
        data[1] = novy_pin
        print(data[1])
    else:
        print("Zadané hesla se neshodují.")
def menu():
    print("*         MENU        *")
    print("   *      Změna pinu     *")
    print("   *   Zůstatek   *")
    print("   *     Výběr    *")
    print("   *     Konec    *")

    odpoved = input("Vaše volba: ")
    while odpoved != str("Konec"):
            if odpoved == str("Změna pinu"):
                        zmena_pinu()
                        break
                        
            elif odpoved == str("Zůstatek"):
                        print(data[2])
                        break
            elif odpoved == str("Výběr"):
                        vybrat_hotovost()
                        break
    else:
                        print("Děkuji za používání.")
                        exit()

for line in karty.split("\n"):
        data = line.split(" ")
while pocet_pokusu <= 2:
    cislo_karty = input("Zadejte cislo karty: ")
    pin_karty = input("Zadejte pin karty: ")
    if cislo_karty == data[0] and pin_karty == data[1]:
                
        while menu_funkce == 0:
                menu()
                print("")
                print("")
       
    elif cislo_karty != data[0] and pin_karty != data[1]:
                pocet_pokusu += 1
                print("Počet špatných pokusů: "+ str(pocet_pokusu))

else:
    print("Příliš špatných pokusů")
    exit()
    


