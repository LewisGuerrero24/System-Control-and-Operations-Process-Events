package com.example.SGI.infrastructure.repository;

import com.example.SGI.domain.models.Customer;
import com.example.SGI.domain.models.Product;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ProductRepository extends JpaRepository<Product,Long> {
}
