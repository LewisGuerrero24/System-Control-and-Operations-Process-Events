package com.example.SGV.infrastructure.controller;

import com.example.SGV.application.services.CustomerServices;
import com.example.SGV.domain.models.Customer;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class CustomerController {

    private final CustomerServices customerServices;


    public CustomerController(CustomerServices customerServices) {
        this.customerServices = customerServices;
    }

    @GetMapping("/")
    public String home() {
        return "Bienvenido a la aplicación Spring Boot";
    }

    @GetMapping("/customers")
    public Customer getCustomerById() {
        Customer customer = new Customer(123,"Lewis Manzano","Lewisguerrero20@gmail.com");
        return customerServices.findCustomer(customer);
    }
}
