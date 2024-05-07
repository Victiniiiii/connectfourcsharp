import os
import random
import time

rows = {
    "row0": [".", ".", ".", ".", ".", ".", "."],
    "row1": [".", ".", ".", ".", ".", ".", "."],
    "row2": [".", ".", ".", ".", ".", ".", "."],
    "row3": [".", ".", ".", ".", ".", ".", "."],
    "row4": [".", ".", ".", ".", ".", ".", "."],
    "row5": [".", ".", ".", ".", ".", ".", "."]
}

char1 = input("select player1 sign (enter for default): ")
if char1 == "":
    char1 = "X"

char2 = input("select player2 sign (enter for default): ")
if char2 == "":
    char2 = "O"

game_mode = int(input("select game mode;\n"
                      "1 to connect four (p v p),\n"
                      "2 to connect four (p v cpu),\n"
                      "3 to connect four (cpu v cpu),\n"
                      "4 to xox advanced (p v p),\n"
                      "5 to xox advanced (p v cpu),\n"
                      "6 to xox advanced (cpu v cpu): "))

if game_mode >= 4:
    def player1(r1, c1):
        if rows[f"row{r1}"][c1] == ".":
            rows[f"row{r1}"][c1] = char1

    def player2(r2, c2):
        if rows[f"row{r2}"][c2] == ".":
            rows[f"row{r2}"][c2] = char2

else:
    def player1(c1):
        for i in range(5, -1, -1):
            if rows[f"row{i}"][c1] == ".":
                rows[f"row{i}"][c1] = char1
                break

    def player2(c2):
        for i in range(5, -1, -1):
            if rows[f"row{i}"][c2] == ".":
                rows[f"row{i}"][c2] = char2
                break


def check_win(char):
    c0 = check_hrzn(char)
    c1 = check_vert(char)
    c2 = check_cross_to_right(char)
    c3 = check_cross_to_left(char)

    if 1 in (c0, c1, c2, c3):
        return 1
    else:
        return 0


def check_hrzn(char):
    for row in rows.values():
        for i in range(4):  # this 4 is because shifting right, will be 3 in vert
            if row[i] + row[i+1] + row[i+2] + row[i+3] == char * 4:  # this now is for connect 4
                return 1
    return 0


def check_vert(char):
    columns = {
        "column0": [rows[row][0] for row in rows],
        "column1": [rows[row][1] for row in rows],
        "column2": [rows[row][2] for row in rows],
        "column3": [rows[row][3] for row in rows],
        "column4": [rows[row][4] for row in rows],
        "column5": [rows[row][5] for row in rows],
        "column6": [rows[row][6] for row in rows],
    }

    for column in columns.values():
        for i in range(3):  # this 4 is because shifting right, will be 3 in vert
            if column[i] + column[i+1] + column[i+2] + column[i+3] == char * 4:  # this now is for connect 4
                return 1
    return 0


def check_cross_to_right(char):  # shifting will be to right, then to bottom
    for r in range(3):
        for c in range(4):
            if rows[f"row{r}"][c] + rows[f"row{r+1}"][c+1] + rows[f"row{r+2}"][c+2] + rows[f"row{r+3}"][c+3] == char * 4:
                return 1
    return 0


def check_cross_to_left(char):
    for r in range(3):
        for c in range(4):
            if rows[f"row{r}"][c+3] + rows[f"row{r+1}"][c+2] + rows[f"row{r+2}"][c+1] + rows[f"row{r+3}"][c] == char * 4:
                return 1
    return 0


if game_mode == 4:
    while True:
        for row in rows:
            print(rows[row])

        posr1 = int(input("p1, select row: "))
        posc1 = int(input("p1, select column: "))
        player1(posr1, posc1)
        if check_win(char1) == 1:
            print("p1 has won!")
            for row in rows:
                print(rows[row])
            break

        os.system("clear")

        for row in rows:
            print(rows[row])

        posr2 = int(input("p2, select row: "))
        posc2 = int(input("p2, select column: "))
        player2(posr2, posc2)
        if check_win(char2) == 1:
            print("p2 has won!")
            for row in rows:
                print(rows[row])
            break

        os.system("clear")

elif game_mode == 1:
    while True:
        for row in rows:
            print(rows[row])

        posc1 = int(input("p1, select column: "))
        player1(posc1)
        if check_win(char1) == 1:
            print("p1 has won!")
            for row in rows:
                print(rows[row])
            break

        os.system("clear")

        for row in rows:
            print(rows[row])

        posc2 = int(input("p2, select column: "))
        player2(posc2)
        if check_win(char2) == 1:
            print("p2 has won!")
            for row in rows:
                print(rows[row])
            break

        os.system("clear")

elif game_mode == 5:
    while True:
        for row in rows:
            print(rows[row])

        posr1 = int(input("p1, select row: "))
        posc1 = int(input("p1, select column: "))
        player1(posr1, posc1)
        if check_win(char1) == 1:
            print("p1 has won!")
            for row in rows:
                print(rows[row])
            break

        os.system("clear")

        for row in rows:
            print(rows[row])

        time.sleep(random.randint(18, 3))

        posr2 = random.randint(0, 5)
        posc2 = random.randint(0, 6)
        player2(posr2, posc2)
        if check_win(char2) == 1:
            print("p2 has won!")
            for row in rows:
                print(rows[row])
            break

        os.system("clear")

elif game_mode == 2:
    while True:
        for row in rows:
            print(rows[row])

        posc1 = int(input("p1, select column: "))
        player1(posc1)
        if check_win(char1) == 1:
            print("p1 has won!")
            for row in rows:
                print(rows[row])
            break

        os.system("clear")

        for row in rows:
            print(rows[row])

        time.sleep(random.randint(1, 3))

        posc2 = random.randint(0, 6)
        player2(posc2)
        if check_win(char2) == 1:
            print("p2 has won!")
            for row in rows:
                print(rows[row])
            break

        os.system("clear")

elif game_mode == 6:
    while True:
        for row in rows:
            print(rows[row])

        time.sleep(random.randint(1, 3))

        posr1 = random.randint(0, 5)
        posc1 = random.randint(0, 6)
        player1(posr1, posc1)
        if check_win(char1) == 1:
            print("p1 has won!")
            for row in rows:
                print(rows[row])
            break

        os.system("clear")

        for row in rows:
            print(rows[row])

        time.sleep(random.randint(1, 3))

        posr2 = random.randint(0, 5)
        posc2 = random.randint(0, 6)
        player2(posr2, posc2)
        if check_win(char2) == 1:
            print("p2 has won!")
            for row in rows:
                print(rows[row])
            break

        os.system("clear")

else:
    while True:
        for row in rows:
            print(rows[row])

        time.sleep(random.randint(1, 3))

        posc1 = random.randint(0, 6)
        player1(posc1)
        if check_win(char1) == 1:
            print("p1 has won!")
            for row in rows:
                print(rows[row])
            break

        os.system("clear")

        for row in rows:
            print(rows[row])

        time.sleep(random.randint(1, 3))

        posc2 = random.randint(0, 6)
        player2(posc2)
        if check_win(char2) == 1:
            print("p2 has won!")
            for row in rows:
                print(rows[row])
            break

        os.system("clear")

print("program has ended")