﻿using System.ComponentModel.DataAnnotations;

namespace GameStore.API;

public record class UpdateGameDto(
    [Required]int Id,
    [Required][StringLength(50)]string Name, 
    [Required][StringLength(20)]string Genre, 
    [Range(1,100)]decimal Price, 
    DateOnly ReleaseDate);
