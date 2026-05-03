# 任务清单: 模式校验恒真

目录: `helloagents/plan/202601201852_force_memory_checks_true/`

---

## 1. Memory 模块
- [√] 1.1 在 `ReMakePlacePlugin/Memory.cs` 中将 `IsHousingMode` 改为恒 true，验证 why.md#需求-模式校验恒真-场景-保存加载染色不受模式限制
- [√] 1.2 在 `ReMakePlacePlugin/Memory.cs` 中将 `CanEditItem`/`CanDyeItem` 改为恒 true，验证 why.md#需求-模式校验恒真-场景-保存加载染色不受模式限制

## 2. 安全检查
- [√] 2.1 执行安全检查（按 G9: 输入验证、敏感信息处理、权限控制、EHRB 风险规避）

## 3. 文档更新
- [√] 3.1 更新 `helloagents/wiki/modules/memory.md`
- [√] 3.2 更新 `helloagents/CHANGELOG.md`

## 4. 测试
- [-] 4.1 手动验证：非布局/染色模式下触发保存/加载/染色流程
> 备注: 未执行（需手动验证）
