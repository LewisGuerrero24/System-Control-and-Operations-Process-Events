package com.example.SGI.domain.ports;

import com.example.SGI.domain.models.Customer;

public interface CustomerPorts {
    Customer findByCustomer(Customer customer);
}
