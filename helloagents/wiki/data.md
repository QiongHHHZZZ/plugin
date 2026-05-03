# 数据模型

## 概述
布局以 JSON 文件存储，运行时使用内存结构与配置对象进行处理。

---

## 数据表/集合

### 布局文件（Layout）
**描述:** 保存房屋布局与家具信息。

| 字段名 | 类型 | 约束 | 说明 |
|--------|------|------|------|
| playerTransform | Transform | 必填 | 玩家位置与旋转 |
| houseSize | string | 可选 | 房屋大小/区域 |
| interiorScale | float | 必填 | 室内缩放 |
| interiorFixture | Fixture[] | 可选 | 室内固定件 |
| interiorFurniture | Furniture[] | 可选 | 室内家具 |
| exteriorScale | float | 必填 | 室外缩放 |
| exteriorFixture | Fixture[] | 可选 | 室外固定件 |
| exteriorFurniture | Furniture[] | 可选 | 室外家具 |
| properties | map | 可选 | 额外属性 |

### 家具（Furniture）
**描述:** 布局中单件家具的定义。

| 字段名 | 类型 | 约束 | 说明 |
|--------|------|------|------|
| name | string | 可选 | 物品名称 |
| itemId | uint | 可选 | 物品 ID |
| transform | Transform | 必填 | 位置与旋转 |
| properties | map | 可选 | 颜色/材质等 |
| attachments | Furniture[] | 可选 | 附着家具 |

### 变换（Transform）
**描述:** 位置与旋转信息。

| 字段名 | 类型 | 约束 | 说明 |
|--------|------|------|------|
| location | float[3] | 必填 | X/Y/Z 位置 |
| rotation | float[4] | 必填 | 四元数 |
| scale | float[3] | 必填 | 缩放 |

### 插件配置（Configuration）
**描述:** 插件运行参数与 UI 选项。

| 字段名 | 类型 | 约束 | 说明 |
|--------|------|------|------|
| LoadInterval | int | 必填 | 放置间隔（ms） |
| SaveLocation | string | 可选 | 默认文件路径 |
| Basement/GroundFloor/UpperFloor | bool | 必填 | 楼层过滤 |
| AutoConfirmDye | bool | 可选 | 自动确认染色 |