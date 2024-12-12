package com.example.SFF.domain.ports;

import com.example.SFF.domain.models.Customer;

public interface CustomerPorts {
    Customer findByCustomer(Customer customer);
}