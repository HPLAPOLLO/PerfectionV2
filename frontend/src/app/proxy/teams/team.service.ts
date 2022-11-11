import type { CreateUpdateTeamDto, TeamDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class TeamService {
  apiName = 'Default';
  

  create = (input: CreateUpdateTeamDto) =>
    this.restService.request<any, TeamDto>({
      method: 'POST',
      url: '/api/app/team',
      body: input,
    },
    { apiName: this.apiName });
  

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/team/${id}`,
    },
    { apiName: this.apiName });
  

  get = (id: string) =>
    this.restService.request<any, TeamDto>({
      method: 'GET',
      url: `/api/app/team/${id}`,
    },
    { apiName: this.apiName });
  

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<TeamDto>>({
      method: 'GET',
      url: '/api/app/team',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });
  

  update = (id: string, input: CreateUpdateTeamDto) =>
    this.restService.request<any, TeamDto>({
      method: 'PUT',
      url: `/api/app/team/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
