#ifndef HAL_GPIO_H
#define HAL_GPIO_H

#include "../config/pin_config.h"
#include<avr/io.h>
void hal_init(uint8_t led_pin,uint8_t button_pin );
uint8_t hal_read(uint8_t button_pin);
void hal_set(uint8_t led_pin);
void hal_clear(uint8_t led_pin);
void hal_toggle(uint8_t led_pin);

#endif




