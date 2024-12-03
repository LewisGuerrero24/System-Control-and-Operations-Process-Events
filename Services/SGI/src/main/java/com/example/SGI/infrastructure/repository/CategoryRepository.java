package com.example.SGI.infrastructure.repository;

import com.example.SGI.domain.models.Category;
import org.springframework.data.jpa.repository.JpaRepository;

public interface CategoryRepository extends JpaRepository<Category,Long> {
}
