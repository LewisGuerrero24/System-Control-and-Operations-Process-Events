package com.example.SGI.infrastructure.controller;

import com.example.SGI.application.services.KafkaServices;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class KafkaController {

    @Autowired
    private KafkaServices kafkaServices;

    @PostMapping("/send")
    public String sendMessage(@RequestParam("message") String message) {
        kafkaServices.kafkaSendMessage("sales-transactions", message);
        return "Message sent: " + message;
    }
}
