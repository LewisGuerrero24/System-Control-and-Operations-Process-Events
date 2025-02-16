package main

import (
	"net/http"

	"github.com/gin-gonic/gin"
)

func main() {
	// Crear instancia del router Gin
	r := gin.Default()

	// Ruta GET
	r.GET("/", func(c *gin.Context) {
		c.JSON(http.StatusOK, gin.H{
			"message": "¡Hola, Gin!",
		})
	})

	// Ruta POST (ejemplo)
	r.POST("/user", func(c *gin.Context) {
		var user struct {
			Name string `json:"name"`
			Age  int    `json:"age"`
		}

		if err := c.BindJSON(&user); err != nil {
			c.JSON(http.StatusBadRequest, gin.H{"error": err.Error()})
			return
		}

		c.JSON(http.StatusOK, gin.H{"user": user})
	})

	// Levantar servidor en el puerto 8080
	r.Run(":4050")
}
