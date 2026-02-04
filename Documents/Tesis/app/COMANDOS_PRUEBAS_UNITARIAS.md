# PRUEBAS UNITARIAS - BACKEND

✅ **ESTADO ACTUAL**: Las 18 pruebas unitarias han sido implementadas completamente.

## Tests Implementados

Se crearon **6 archivos de test** con un total de **45 tests unitarios** (18 requeridos + 27 adicionales):

1. **LoginServiceTest.java** - 5 tests (Autenticación)
2. **JwtUtilTest.java** - 8 tests (JWT)
3. **PasswordEncoderTest.java** - 9 tests (Encriptación BCrypt)
4. **ProcessServiceTest.java** - 7 tests (Validación de Procesos)
5. **AnswerServiceTest.java** - 7 tests (Validación de Respuestas)
6. **ApprovalServiceTest.java** - 9 tests (Validación de Aprobaciones)

---

## EJECUTAR TODOS LOS TESTS

```powershell
cd c:\Users\bryanesteban\Documents\Tesis\app\backend\ListoEgsi
mvn test
```

Este comando ejecutará todos los 45 tests implementados.

---

## EJECUTAR TESTS POR ARCHIVO

### 1. Tests de Autenticación (LoginService)
```powershell
mvn test -Dtest=LoginServiceTest
```
**Cubre TC-UT-001 a TC-UT-003**: Login válido, password inválida, usuario inexistente

### 2. Tests de JWT
```powershell
mvn test -Dtest=JwtUtilTest
```
**Cubre TC-UT-004**: Expiración de tokens, generación, validación

### 3. Tests de Encriptación
```powershell
mvn test -Dtest=PasswordEncoderTest
```
**Cubre TC-UT-005**: Encriptación BCrypt, formato, sal aleatoria

### 4. Tests de Procesos
```powershell
mvn test -Dtest=ProcessServiceTest
```
**Cubre TC-UT-006 a TC-UT-010**: Validación de nombre, creador, estado

### 5. Tests de Respuestas
```powershell
mvn test -Dtest=AnswerServiceTest
```
**Cubre TC-UT-011 a TC-UT-014**: Validación de texto, questionId, processId

### 6. Tests de Aprobaciones
```powershell
mvn test -Dtest=ApprovalServiceTest
```
**Cubre TC-UT-015 a TC-UT-018**: Validación de processId, phaseId, comentarios en rechazo

---

## TESTS IMPLEMENTADOS (18/18 ✅)

### 1. Autenticación y Seguridad (5 tests)
- ✅ TC-UT-001: Login con credenciales correctas
- ✅ TC-UT-002: Login con password incorrecta  
- ✅ TC-UT-003: Login con usuario inexistente
- ✅ TC-UT-004: Token JWT expira después de tiempo configurado
- ✅ TC-UT-005: Encriptación de password

### 2. Validación de Procesos (5 tests)
- ✅ TC-UT-006: Validar creación de proceso con datos válidos
- ✅ TC-UT-007: Proceso rechaza nombre vacío
- ✅ TC-UT-008: Proceso rechaza nombre con más de 200 caracteres
- ✅ TC-UT-009: Proceso requiere usuario creador válido
- ✅ TC-UT-010: Proceso requiere fase EGSI válida

### 3. Validación de Respuestas (4 tests)
- ✅ TC-UT-011: Validar respuesta con texto válido
- ✅ TC-UT-012: Respuesta rechaza texto vacío
- ✅ TC-UT-013: Respuesta requiere questionId
- ✅ TC-UT-014: Respuesta requiere processId

### 4. Validación de Aprobaciones (4 tests)
- ✅ TC-UT-015: Validar solicitud de aprobación con datos válidos
- ✅ TC-UT-016: Aprobación requiere processId
- ✅ TC-UT-017: Aprobación requiere phaseId
- TC-UT-018: Aprobación requiere comentario si es rechazo

---

## PRÓXIMOS PASOS

Para implementar las pruebas unitarias, necesitas crear los archivos de test:

```
src/test/java/com/espe/ListoEgsi/
├── service/
│   ├── auth/
│   │   ├── LoginServiceTest.java
│   │   └── JwtUtilTest.java
│   ├── process/
│   │   └── ProcessServiceTest.java
│   ├── answer/
│   │   └── AnswerServiceTest.java
│   └── approval/
│       └── ApprovalServiceTest.java
└── security/
    └── PasswordEncoderTest.java
```

---

## VERIFICAR ESTADO ACTUAL

```powershell
# Ver estructura de tests
Get-ChildItem -Path "src\test\java" -Recurse

# Ejecutar tests existentes
mvn test

# Ver resultado
# Debe mostrar: Tests run: 1, Failures: 0, Errors: 0, Skipped: 0
```

---

## ALTERNATIVA: EJECUTAR TESTS DE INTEGRACIÓN

Ya que las pruebas unitarias no existen, puedes probar la funcionalidad con **Smoke Tests** (ya documentados):

Ver archivo: `COMANDOS_TESTS.md`

---

## EJECUTAR TESTS ESPECÍFICOS POR CATEGORÍA

### 1. Tests de Autenticación (TC-UT-001 a TC-UT-005)
```powershell
mvn test -Dtest=LoginServiceTest
mvn test -Dtest=JwtUtilTest
mvn test -Dtest=PasswordEncoderTest
```

### 2. Tests de Validación de Procesos (TC-UT-006 a TC-UT-010)
```powershell
mvn test -Dtest=ProcessServiceTest
```

### 3. Tests de Respuestas (TC-UT-011 a TC-UT-014)
```powershell
mvn test -Dtest=AnswerServiceTest
```

### 4. Tests de Aprobaciones (TC-UT-015 a TC-UT-018)
```powershell
mvn test -Dtest=ApprovalServiceTest
```

---

## LISTAR TESTS DISPONIBLES

```powershell
# Ver todos los tests del proyecto
Get-ChildItem -Path "src\test\java" -Recurse -Filter "*Test.java" | Select-Object Name, FullName
```

---

## GENERAR REPORTE DE COBERTURA

```powershell
# Ejecutar tests con cobertura
mvn clean test jacoco:report

# Ver reporte en:
# target/site/jacoco/index.html
```

---

## TESTS INDIVIDUALES (Por Caso de Prueba)

### TC-UT-001: Login con credenciales correctas
```powershell
mvn test -Dtest=LoginServiceTest#testLoginWithValidCredentials
```

### TC-UT-002: Login con password incorrecta
```powershell
mvn test -Dtest=LoginServiceTest#testLoginWithInvalidPassword
```

### TC-UT-003: Login con usuario inexistente
```powershell
mvn test -Dtest=LoginServiceTest#testLoginWithNonExistentUser
```

### TC-UT-004: Token JWT expira
```powershell
mvn test -Dtest=JwtUtilTest#testTokenExpiration
```

### TC-UT-005: Encriptación de password
```powershell
mvn test -Dtest=PasswordEncoderTest#testPasswordEncryption
```

### TC-UT-006: Validar creación de proceso válido
```powershell
mvn test -Dtest=ProcessServiceTest#testValidProcessCreation
```

### TC-UT-007: Proceso rechaza nombre vacío
```powershell
mvn test -Dtest=ProcessServiceTest#testProcessRejectsEmptyName
```

### TC-UT-008: Proceso rechaza nombre largo
```powershell
mvn test -Dtest=ProcessServiceTest#testProcessRejectsLongName
```

### TC-UT-009: Proceso requiere usuario creador
```powershell
mvn test -Dtest=ProcessServiceTest#testProcessRequiresCreator
```

### TC-UT-010: Proceso requiere fase EGSI válida
```powershell
mvn test -Dtest=ProcessServiceTest#testProcessRequiresValidStatus
```

### TC-UT-011: Validar respuesta con texto válido
```powershell
mvn test -Dtest=AnswerServiceTest#testValidAnswer
```

### TC-UT-012: Respuesta rechaza texto vacío
```powershell
mvn test -Dtest=AnswerServiceTest#testAnswerRejectsEmptyText
```

### TC-UT-013: Respuesta requiere questionId
```powershell
mvn test -Dtest=AnswerServiceTest#testAnswerRequiresQuestionId
```

### TC-UT-014: Respuesta requiere processId
```powershell
mvn test -Dtest=AnswerServiceTest#testAnswerRequiresProcessId
```

### TC-UT-015: Validar solicitud de aprobación válida
```powershell
mvn test -Dtest=ApprovalServiceTest#testValidApproval
```

### TC-UT-016: Aprobación requiere processId
```powershell
mvn test -Dtest=ApprovalServiceTest#testApprovalRequiresProcessId
```

### TC-UT-017: Aprobación requiere phaseId
```powershell
mvn test -Dtest=ApprovalServiceTest#testApprovalRequiresPhaseId
```

### TC-UT-018: Aprobación requiere comentario si es rechazo
```powershell
mvn test -Dtest=ApprovalServiceTest#testApprovalRequiresCommentOnRejection
```

---

## VER RESULTADOS

### Reporte en terminal
```powershell
mvn test | Select-String "Tests run:|PASS|FAIL"
```

### Reporte HTML
```powershell
# Generar reporte surefire
mvn surefire-report:report

# Abrir reporte en:
# target/site/surefire-report.html
Start-Process "target\site\surefire-report.html"
```

---

## VERIFICAR TESTS EXISTENTES

```powershell
# Buscar archivos de test
Get-ChildItem -Path "src\test\java" -Recurse -Filter "*Test.java"

# Contar tests
(Get-ChildItem -Path "src\test\java" -Recurse -Filter "*Test.java").Count
```

---

## COMANDOS ÚTILES

### Limpiar y ejecutar tests
```powershell
mvn clean test
```

### Saltar tests (para build rápido)
```powershell
mvn clean install -DskipTests
```

### Ejecutar solo tests que fallaron anteriormente
```powershell
mvn test -Dsurefire.rerunFailingTestsCount=2
```

### Ver log detallado
```powershell
mvn test -X
```

---

## ESTRUCTURA DE TESTS

```
src/test/java/com/espe/ListoEgsi/
├── service/
│   ├── auth/
│   │   ├── LoginServiceTest.java          # TC-UT-001, 002, 003
│   │   └── JwtUtilTest.java               # TC-UT-004
│   ├── process/
│   │   └── ProcessServiceTest.java        # TC-UT-006 a 010
│   ├── answer/
│   │   └── AnswerServiceTest.java         # TC-UT-011 a 014
│   └── approval/
│       └── ApprovalServiceTest.java       # TC-UT-015 a 018
└── security/
    └── PasswordEncoderTest.java           # TC-UT-005
```

---

## NOTAS IMPORTANTES

1. **Antes de ejecutar**: Asegúrate de que MySQL esté levantado
   ```powershell
   docker-compose up -d mysql
   ```

2. **Tests usan BD de prueba**: application-test.properties
   - Base de datos: siegsi_test
   - No afecta datos de producción

3. **Mocks**: Algunos tests usan @MockBean para no depender de BD

4. **Cobertura mínima**: 80% en servicios críticos

5. **Ejecutar antes de commit**: `mvn test` debe pasar antes de push
