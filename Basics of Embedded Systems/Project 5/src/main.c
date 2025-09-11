#include <util/delay.h>

#include "./../hal/hal_gpio.h"
#include "pin_config.h"



int main(void) {
    uint8_t mode = 0;   
    uint8_t button_state, last_button = 1; 

    hal_init(LED_PIN, BUTTON_PIN);

    while (1) {
      button_state = hal_read(BUTTON_PIN);

      if (button_state == 0 && last_button == 1) {
        mode = (mode + 1) % 3; 
      }
      last_button = button_state;

      if (mode == 0) {               
        hal_toggle(LED_PIN);
        _delay_ms(1000);
      }
      else if (mode == 1) {          
        hal_toggle(LED_PIN);
        _delay_ms(200);
      }
      else {                        
        hal_set(LED_PIN);
        _delay_ms(50);           
        }
    }
}