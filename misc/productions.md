# All

All the ghosts have this actions and sensors. Specific sensors and actions are
listed in the ghost's section.

## Actions

- N – move up
- S – move down
- W – move right
- E – move left

## Sensors

- WN – wall north
- WS – wall south
- WE – wall east
- WW – wall west
- C – chase mode
- F - frightened
- N - node

# Inky
## Productions

1. ~WN, WS, WE, WW, ~F, C, ~N -> N
2. ~WS, WN, WE, WW, ~F, C, ~N -> S
3. ~WE, WN, WS, WW, ~F, C, ~N -> E
4. ~WW, WN, WS, WE, ~F, C, ~N -> W
5. ~WN, ~WS, ~WE, ~WW, ~F, C, N -> N | S | E | W
6. ~WS, ~WN, ~WE, WW, ~F, C, N -> N | S | E
7. ~WE, ~WN, WS, ~WW, ~F, C, N -> N | E | W
8. ~WW, WN, ~WS, ~WE, ~F, C, N -> S | E | W
9. ~WN, WS, ~WE, WW, ~F, C, N -> N | E
10. ~WS, WN, WW, ~WE, ~F, C, N -> S | E
11. ~WN, ~WW, WS, WE, ~F, C, N -> N | W
12. ~WS, ~WW, WN, WE, ~F, C, N -> W | S

# Blinky
## Sensors

- DN – closest pacman direction north
- DS – closest pacman direction south
- DE – closest pacman direction east
- DW – closest pacman direction west

## Productions

1. ~WN, ~WS, ~WE, ~WW, ~F, C, N, DN -> N
2. ~WN, ~WS, ~WE, ~WW, ~F, C, N, DS -> S
3. ~WN, ~WS, ~WE, ~WW, ~F, C, N, DE -> E
4. ~WN, ~WS, ~WE, ~WW, ~F, C, N, DW -> W
5. ~WN, ~WS, ~WE, WW, ~F, C, N, DN -> N
6. ~WN, ~WS, ~WE, WW, ~F, C, N, DS -> S
7. ~WN, ~WS, ~WE, WW, ~F, C, N, DE -> E
8. ~WN, ~WS, WE, ~WW, ~F, C, N, DN -> N
9. ~WN, ~WS, WE, ~WW, ~F, C, N, DS -> S
10. WS, ~WN, ~WE, ~WW, ~F, C, N, DE -> E
11. WS, ~WN, ~WE, ~WW, ~F, C, N, DN -> N
12. WS, ~WN, ~WE, ~WW, ~F, C, N, DW -> W
13. ~WN, ~WS, WE, ~WW, ~F, C, N, DW -> W
14. ~WN, WS, ~WE, ~WW, ~F, C, N, DN -> N
15. ~WN, WS, ~WE, ~WW, ~F, C, N, DE -> E
16. ~WN, WS, ~WE, ~WW, ~F, C, N, DW -> W
17. WN, ~WS, WE, ~WW, ~F, C, N, DS -> S
18. WN, ~WS, WE, ~WW, ~F, C, N, DW -> W
19. ~WN, WS, WE, ~WW, ~F, C, N, DN -> N
20. ~WN, WS, WE, ~WW, ~F, C, N, DW -> W
21. ~WN, WS, ~WE, WW, ~F, C, N, DN -> N
22. ~WN, WS, ~WE, WW, ~F, C, N, DE -> E
23. WN, ~WS, ~WE, WW, ~F, C, N, DS -> S
24. WN, ~WS, ~WE, WW, ~F, C, N, DE -> E

# Pinky
## Sensors

- DN – closest to four steps ahead of pacman
- DS – closest to four steps behind pacman
- DE – closest to four steps right of pacman
- DW – closest to four steps left of pacman

## Productions

1. ~WN, ~WS, ~WE, ~WW, ~F, C, N, DN -> N
2. ~WN, ~WS, ~WE, ~WW, ~F, C, N, DS -> S
3. ~WN, ~WS, ~WE, ~WW, ~F, C, N, DE -> E
4. ~WN, ~WS, ~WE, ~WW, ~F, C, N, DW -> W
5. ~WN, ~WS, ~WE, WW, ~F, C, N, DN -> N
6. ~WN, ~WS, ~WE, WW, ~F, C, N, DS -> S
7. ~WN, ~WS, ~WE, WW, ~F, C, N, DE -> E
8. ~WN, ~WS, WE, ~WW, ~F, C, N, DN -> N
9. ~WN, ~WS, WE, ~WW, ~F, C, N, DS -> S
10. WS, ~WN, ~WE, ~WW, ~F, C, N, DE -> E
11. WS, ~WN, ~WE, ~WW, ~F, C, N, DN -> N
12. WS, ~WN, ~WE, ~WW, ~F, C, N, DW -> W
13. ~WN, ~WS, WE, ~WW, ~F, C, N, DW -> W
14. ~WN, WS, ~WE, ~WW, ~F, C, N, DN -> N
15. ~WN, WS, ~WE, ~WW, ~F, C, N, DE -> E
16. ~WN, WS, ~WE, ~WW, ~F, C, N, DW -> W
17. WN, ~WS, WE, ~WW, ~F, C, N, DS -> S
18. WN, ~WS, WE, ~WW, ~F, C, N, DW -> W
19. ~WN, WS, WE, ~WW, ~F, C, N, DN -> N
20. ~WN, WS, WE, ~WW, ~F, C, N, DW -> W
21. ~WN, WS, ~WE, WW, ~F, C, N, DN -> N
22. ~WN, WS, ~WE, WW, ~F, C, N, DE -> E
23. WN, ~WS, ~WE, WW, ~F, C, N, DS -> S
24. WN, ~WS, ~WE, WW, ~F, C, N, DE -> E

# Clyde
## Sensors

- DN – farthest from closest ghost north
- DS – farthest from closest ghost south
- DE – farthest from closest ghost east
- DW – farthest from closest ghost west

## Productions

1. ~WN, ~WS, ~WE, ~WW, ~F, C, N, DN -> N
2. ~WN, ~WS, ~WE, ~WW, ~F, C, N, DS -> S
3. ~WN, ~WS, ~WE, ~WW, ~F, C, N, DE -> E
4. ~WN, ~WS, ~WE, ~WW, ~F, C, N, DW -> W
5. ~WN, ~WS, ~WE, WW, ~F, C, N, DN -> N
6. ~WN, ~WS, ~WE, WW, ~F, C, N, DS -> S
7. ~WN, ~WS, ~WE, WW, ~F, C, N, DE -> E
8. ~WN, ~WS, WE, ~WW, ~F, C, N, DN -> N
9. ~WN, ~WS, WE, ~WW, ~F, C, N, DS -> S
10. WS, ~WN, ~WE, ~WW, ~F, C, N, DE -> E
11. WS, ~WN, ~WE, ~WW, ~F, C, N, DN -> N
12. WS, ~WN, ~WE, ~WW, ~F, C, N, DW -> W
13. ~WN, ~WS, WE, ~WW, ~F, C, N, DW -> W
14. ~WN, WS, ~WE, ~WW, ~F, C, N, DN -> N
15. ~WN, WS, ~WE, ~WW, ~F, C, N, DE -> E
16. ~WN, WS, ~WE, ~WW, ~F, C, N, DW -> W
17. WN, ~WS, WE, ~WW, ~F, C, N, DS -> S
18. WN, ~WS, WE, ~WW, ~F, C, N, DW -> W
19. ~WN, WS, WE, ~WW, ~F, C, N, DN -> N
20. ~WN, WS, WE, ~WW, ~F, C, N, DW -> W
21. ~WN, WS, ~WE, WW, ~F, C, N, DN -> N
22. ~WN, WS, ~WE, WW, ~F, C, N, DE -> E
23. WN, ~WS, ~WE, WW, ~F, C, N, DS -> S
24. WN, ~WS, ~WE, WW, ~F, C, N, DE -> E

