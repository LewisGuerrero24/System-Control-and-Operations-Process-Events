from fastapi import APIRouter, Depends
from sqlalchemy.orm import Session
from infrastructure.Db.database import get_db

router = APIRouter()

@router.get("/test-db")
def test_database_connection(db: Session = Depends(get_db)):
    try:
        # Verificar si la conexión es exitosa
        db.execute("SELECT 1")
        return {"status": "success", "message": "Database connected successfully"}
    except Exception as e:
        return {"status": "error", "message": str(e)}
