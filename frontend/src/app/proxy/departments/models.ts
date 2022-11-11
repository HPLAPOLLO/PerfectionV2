import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateDepartmentDto {
  description: string;
}

export interface DepartmentDto extends AuditedEntityDto<string> {
  description?: string;
}
