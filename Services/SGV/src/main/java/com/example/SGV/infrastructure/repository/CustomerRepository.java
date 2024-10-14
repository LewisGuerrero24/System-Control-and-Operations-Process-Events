package com.example.SGV.infrastructure.repository;

import com.example.SGV.domain.models.Customer;
import org.springframework.data.jpa.repository.JpaRepository;


public interface CustomerRepository extends JpaRepository<Customer,Long> {
}
