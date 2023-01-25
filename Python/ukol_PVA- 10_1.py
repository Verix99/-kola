import random 

print('Vítej v mé hře......')
jmeno_hl_postava = input("Zadejte jméno své postavy: ")
jmeno_nepritel_postava = input("Zadejte jméno nepřítele: ")
sila_hl = random.randint(0,10)
hp_hl = sila_hl * 10                    ##random.randint(0,10)

sila_nepritel = random.randint(0,10)
hp_nepritel = sila_nepritel * 10                 ##random.randint(0,10)


while hp_hl or hp_nepritel > 0:
        poradi = random.randint(0,1)
        print(poradi)
        if poradi == 1:
            utok_hl = sila_hl * random.randint(1,6)
            hp_nepritel = hp_nepritel - utok_hl
            print("Hrdina: " + str(hp_hl))
            if hp_hl <= 0:
                print("Vyhrál:" + jmeno_nepritel_postava)
                break
        else:
            utok_nepritel = sila_nepritel * random.randint(1,6)
            hp_hl = hp_hl - utok_nepritel
            print("Nepritel: " + str(hp_nepritel))
            if hp_nepritel <= 0:
                print("Vyhrál: " + jmeno_hl_postava)
                break


