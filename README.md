# embedded_system_software
Laboratory works for embedded system software 

All projects are for [STM32F103RB](https://www.st.com/en/microcontrollers-microprocessors/stm32f103rb.html)

## Hello world (1st lab)
User button toggles green led

## Snake (2nd lab)
Snake on leds. User can set different speeds for snake by pressing buttons. Also the speed value is showed on 7-segment display.
![snake](https://github.com/crushnik0546/embedded_system_software/blob/main/results/snake.gif)

## Stopwatch (3rd lab)
![Stopwatch](https://github.com/crushnik0546/embedded_system_software/blob/main/results/stopwatch.gif)

## Сommunication via com port
Microcontroller -> desktop programs: STM32 gets data from lightning sensor and from potentiometer and sends it to desktop programm which displays charts with these values in real time.
Desktop program -> microcontroller: user can turn on/off blue and red leds and set RGB values to RGB led on shield.
