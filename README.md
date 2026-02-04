# LAB THỰC HÀNH - CHƯƠNG 5: PHYSICS (UNITY)

## Mục Tiêu
Nắm vững hệ thống Physics trong Unity: Collider 2D/3D, Rigidbody 2D/3D, Effector 2D, Character Controller, xử lý va chạm và trigger.

---

## LAB 1: Collider 2D Cơ Bản

**Nội dung**: Tạo scene 2D với các Collider2D khác nhau (Box, Circle, Polygon). Quan sát va chạm giữa Player và vật cản.

**Video Demo**: 

https://github.com/user-attachments/assets/f5cb2767-aa66-417b-8532-9fcaceb215ac

---

## LAB 2: Rigidbody 2D & Collision Event

**Nội dung**: Gắn Rigidbody2D cho Player. Xử lý OnCollisionEnter2D và OnTriggerEnter2D. Ghi log sự kiện va chạm/trigger.

**Video Demo**: 

https://github.com/user-attachments/assets/fc2f6464-9495-4010-a399-69a49647e50e

---

## LAB 3: Physics Material 2D

**Nội dung**: Tạo Physics Material 2D (ma sát thấp + bounce cao vs ma sát cao + bounce thấp). So sánh chuyển động hai quả bóng.

**Video Demo**: 

https://github.com/user-attachments/assets/ff2ce46f-d5ad-43ab-b0a7-b0d02ee40429

---

## LAB 4: Effector 2D

**Nội dung**: 
- **PlatformEffector2D**: Tạo nền tảng một chiều (one-way platform)
- **SurfaceEffector2D**: Tạo băng chuyền (conveyor belt)

**Video Demo**: 

https://github.com/user-attachments/assets/7c5b6d56-182c-4961-9812-5c85e30f9b7b

---

## LAB 5: Collider & Rigidbody 3D

**Nội dung**: Tạo scene 3D với BoxCollider, SphereCollider và Rigidbody. Sử dụng AddForce để đẩy vật thể. Quan sát chuyển động vật lý.

**Video Demo**: 

https://github.com/user-attachments/assets/e32bec8f-ec01-424a-82c5-8fd47dd297b3

---

## LAB 6: Trigger vs Collision (3D)

**Nội dung**: 

So sánh IsTrigger = true (không có vật lý, xuyên qua) vs false (có vật lý, bị cản). Xử lý OnTriggerEnter vs OnCollisionEnter.

**So sánh**:
| Tính Chất | Collision | Trigger |
|----------|-----------|---------|
| IsTrigger | false | true |
| Vật lý | Có | Không |
| Xuyên Qua | ❌ | ✅ |
| OnCollisionEnter | ✅ | ❌ |
| OnTriggerEnter | ❌ | ✅ |

**Video Demo**: 

https://github.com/user-attachments/assets/cf6fe790-7dc0-4106-a4f4-a4a97ac1640b

---

## LAB 7: Character Controller

**Nội dung**: Tạo nhân vật với CharacterController. Sử dụng Move(). Thiết lập Step Offset (0.3) và Slope Limit (45°). Nhân vật đi cầu thang và dốc mượt.

**Video Demo**: 

https://github.com/user-attachments/assets/d477f56b-f999-4285-a1f9-c5a7445d3ec5

---

## Tóm Tắt Kiến Thức

**2D Physics**: Collider2D, Rigidbody2D, Physics Material 2D, Effector2D

**3D Physics**: Collider, Rigidbody, Physics Material, CharacterController

**Sự Kiện**: OnCollisionEnter/Exit, OnTriggerEnter/Exit, OnCollisionStay, OnTriggerStay
