#include "hal_gpio.h"


void hal_init(uint8_t led_pin,uint8_t button_pin){
    DDRD |= (1<<led_pin);
    DDRD &= ~(1<<button_pin);
    PORTD |= (1<<button_pin);
}

uint8_t hal_read(uint8_t button_pin){
    return (PIND & (1<<button_pin))?1:0;
    
}

void hal_set(uint8_t led_pin){
    PORTD |= (1<<led_pin)
}

void hal_clear(uint8_t led_pin){
    PORTD &= ~(1<<led_pin)
}

void hal_toggle(uint8_t led_pin){
    //Toggle LED mode
    PORTD ^= (1<<led_pin);
    _delay_ms(500);
}