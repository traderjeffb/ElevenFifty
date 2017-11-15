using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevenNote.Data;
using ElevenNote.Models;

namespace ElevenNote.Services
{
    public class NoteService
    {
        public IEnumerable<NoteListItemModel> GetNotes()
        {
            using (var ctx = new ElevenNoteDbContext() )
            {
                return
                    ctx
                        .Notes
                        .Select(
                             e => new NoteListItemModel

                             {
                                 NoteId = e.NoteId,
                                 Title = e.Title,
                                 CreateUtc = e.CreateUtc,
                                 ModifiedUtc = e.ModifiedUtc
                             })
                        .ToArray();
            }
        }
    }
}
