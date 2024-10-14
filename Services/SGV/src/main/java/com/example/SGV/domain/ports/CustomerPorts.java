package com.example.SGV.domain.ports;

import com.example.SGV.domain.models.Customer;


public interface CustomerPorts {

    Customer findByCustomer(Customer customer);
}
