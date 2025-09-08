//Write a function in Embedded C use LED connection such that
// SET BIT 5 OF A REGISTER
// CLEAR BIT 2
// TOGGLE BIT 7
#include <avr/io.h>
#include <util/delay.h>

#define LED_PIN1 PD2
#define LED_PIN2 PD5
#define LED_PIN3 PD7

int main(void){
    DDRD |= (1 << LED_PIN1);
    DDRD |= (1 << LED_PIN2);
    DDRD |= (1 << LED_PIN3);

    PORTD |= (1 << LED_PIN2);
    PORTD &= ~(1 << LED_PIN3);

    _delay_ms(5000);

    PORTD &= ~(1 << LED_PIN1);
    PORTD |= (1 << LED_PIN2);



    while(1){
      PORTD ^= (1 << LED_PIN3);
      _delay_ms(400);
    }
}