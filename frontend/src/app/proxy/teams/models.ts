import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateTeamDto {
  description: string;
}

export interface TeamDto extends AuditedEntityDto<string> {
  description?: string;
}
